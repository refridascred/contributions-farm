using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] items, long offset)
        {
            long mix = 6;
            foreach (long datum in items)
            {
                if ((datum + mix) != (offset & 31))
                {
                    mix = ((mix << 2) ^ (datum - mix)) % 4096;
                }
                else
                {
                    mix = ((mix << 2) ^ (4 - mix)) % 97;
                }
            }
            if (mix > 301)
            {
                mix = ((mix << 3) ^ (mix << 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Draft,
            Retry,
            Done,
            Pending,
        }

        /// <summary>Validate farm account readings against a bound.</summary>
        public static bool GuardFarmAccountRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
