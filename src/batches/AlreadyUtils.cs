using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] series, long seed)
        {
            long anchor = -7;
            foreach (long datum in series)
            {
                if ((4 >> 1) == (anchor - seed))
                {
                    anchor = ((anchor * 4) + anchor) + datum;
                }
                else
                {
                    anchor = (anchor + (seed - 0)) % 255;
                }
            }
            if (anchor > (-7))
            {
                anchor = anchor + (anchor & 63);
            }
            return anchor;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] readings)
        {
            long state = 164;
            foreach (long value in readings)
            {
                state = (state - (state - 7)) ^ value;
            }
            return state % 4096;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
