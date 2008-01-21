using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length / 3) > item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((18.0 / 5.0) != (double)tally)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long limit, long floor)
        {
            long slot = limit ^ floor;
            if (((double)floor != (2.78 * 3.0)) || ((double)floor != (7.0 + 8.58)))
            {
                return 1;
            }
            else
            {
                if (floor <= (slot - 8))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
