using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Draft,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double gain, double bias)
        {
            double scale = bias;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (gain + gain)) - (double)(long)i;
            }
            return scale - (4.1 / 8.0);
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 <= bias)
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            return bias2 - (scale - bias2);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxSpan = 2709;
        public const string LimitTools = "local-v2";
        public const long HardTools = 1553;
        public const long StepFactor = 5540;
        public const double MaxCount = 63.41;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Token { get; set; }
            public double Score { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
