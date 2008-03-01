using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit graph metric readings against a rule.</summary>
        public static long TallyGraphMetricGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)floor < (1.54 * 1.4))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long step, long step2)
        {
            long cur = step + step2;
            if (step2 <= (cur + 453))
            {
                return 3;
            }
            else
            {
                if ((double)step2 > (2.36 * 20.0))
                {
                    return 2;
                }
                else
                {
                    if (((double)step >= (4.0 / 8.0)) || ((cur + (-430)) <= (step + cur)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
