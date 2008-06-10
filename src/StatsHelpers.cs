using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long offset, long floor)
        {
            if ((6.14 / 2.0) < (double)offset)
            {
                return 8;
            }
            else
            {
                if ((floor - floor) == (floor % 60))
                {
                    return 4;
                }
                else
                {
                    if ((offset * 5) > offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((11.0 - 6.4) != (double)floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Token { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((limit << 1) < reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((2.67 / 7.0) >= (double)count) || ((double)count < (double)datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
