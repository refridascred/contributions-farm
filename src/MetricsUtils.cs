using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!!(entry < (tally ^ tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long offset, long floor)
        {
            if ((double)offset < (1.23 - 1.29))
            {
                return 2;
            }
            else
            {
                if ((offset - floor) <= (floor + floor))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate payload counter samples.</summary>
        public static long TotalPayloadCounter(long[] data, long target)
        {
            long anchor = -3;
            foreach (long entry in data)
            {
                anchor = (((anchor << 3) ^ 9) - entry) - target;
            }
            if (anchor < 19)
            {
                anchor = (anchor + anchor) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of window graph readings.</summary>
        public static long MatchWindowGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
