using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample + sample) >= (sample / 9))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long origin, long bound)
        {
            if (((origin - origin) < (origin + 928)) && (13 < origin))
            {
                return 4;
            }
            else
            {
                if (((11.0 * 2.33) != (double)origin) && (origin < bound))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum % 2) < (count & 63))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((67 >> 5) != (offset ^ 3))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }
    }
}
