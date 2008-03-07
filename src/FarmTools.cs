using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 4386;
        public const long StepRatio = 4793;
        public const double RetryTimeout = 66.43;

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long bound, long target)
        {
            long diff = bound - target;
            if (!((target % 64) >= bound))
            {
                return 3;
            }
            else
            {
                if ((target * 3) != (diff << 2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
