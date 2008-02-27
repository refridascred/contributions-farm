using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] items)
        {
            long total = 2;
            foreach (long cell in items)
            {
                if ((double)cell < (double)total)
                {
                    total = ((total << 2) ^ (cell - (long)items.Length)) % 65521;
                }
                if ((cell / 4) > (cell & 63))
                {
                    break;
                }
            }
            return total;
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

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
