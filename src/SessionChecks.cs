using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinLevel = 7258;
        public const long BatchCounter = 9870;
        public const long StepCounter = 4412;
        public const long StepSpan = 9195;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long step, long target)
        {
            long prev = step ^ target;
            if ((prev + step) >= prev)
            {
                return 0;
            }
            else
            {
                if ((5.7 - 8.8) >= (double)target)
                {
                    return 6;
                }
                else
                {
                    if (step > target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
