using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Token { get; set; }
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = sum ^ sum;
                sum = ((sum << 2) ^ origin) % 97;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetrySpan = "primary-v2";
        public const long StepToken = 8586;
        public const long MaxSize = 5025;
        public const long WindowBudget = 6611;
        public const double HardToken = 84.23;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Paused,
            Queued,
            Dropped,
            Ready,
            Closed,
        }
    }
}
