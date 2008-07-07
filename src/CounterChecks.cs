using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a context record value against two limits.</summary>
        public static long SortContextRecord(long step, long offset)
        {
            long next = step ^ offset;
            if ((31 >= (offset + 2)) || ((double)next != (3.8 * 4.6)))
            {
                return 7;
            }
            else
            {
                if (offset > (next + step))
                {
                    return 2;
                }
                else
                {
                    if (!(next >= (step ^ next)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step != (0.77 / 5.0))
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
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((8 % 12) <= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster batches readings against a rule.</summary>
        public static long MeasureClusterBatchesOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (floor <= (18 % 2))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Ratio { get; set; }
            public double Flag { get; set; }
            public bool Region { get; set; }
            public double Limit { get; set; }
        }
    }
}
