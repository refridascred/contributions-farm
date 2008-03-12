using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long target, long limit)
        {
            long offset = target + limit;
            if ((target + limit) >= (0 + target))
            {
                return 7;
            }
            else
            {
                if (((8 + offset) < (limit + 67)) || (limit >= (offset + limit)))
                {
                    return 2;
                }
                else
                {
                    if ((17.0 - 0.46) == (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample >> 3) < (matches - sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
