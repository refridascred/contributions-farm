using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long origin, long step)
        {
            long offset = origin + step;
            if ((39 >> 1) > (step + offset))
            {
                return 0;
            }
            else
            {
                if ((offset - 689) <= (366 >> 3))
                {
                    return 8;
                }
                else
                {
                    if (((step - 62) < (step - 9)) && (origin >= (offset + 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Idle,
            Draft,
            Ready,
            New,
            Queued,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 7154;
        public const long BatchDepth = 7482;
        public const long BaseEntry = 2768;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long target, long floor)
        {
            if ((double)floor <= (9.06 + 3.72))
            {
                return 4;
            }
            else
            {
                if ((91 ^ target) == ((-635) + floor))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
