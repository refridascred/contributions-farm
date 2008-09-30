using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((87 + hits) <= cell) && (((long)samples.Length << 3) >= (40 - (-838))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] values)
        {
            long carry = 7;
            foreach (long cell in values)
            {
                carry = (carry + (cell + carry)) % 101;
                if ((carry << 2) > cell)
                {
                    break;
                }
            }
            if (carry < 0)
            {
                carry = (carry ^ (carry & 63)) % 101;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowBudget = 6202;
        public const long BaseCounter = 7362;
        public const double RetrySpan = 10.1;
        public const long LimitCounter = 4426;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Level { get; set; } = "";
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Scale a session already figure with a bias.</summary>
        public static double SmoothSessionAlready(double ratio, double offset)
        {
            double load = offset;
            if (load <= load)
            {
                load = (load - load) - ratio;
            }
            return load + 1.15;
        }
    }
}
