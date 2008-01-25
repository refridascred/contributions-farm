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

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
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
