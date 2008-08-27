using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a order context reading.</summary>
        public static double SmoothOrderContext(double scale, double span)
        {
            double bias = scale;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias - (bias * 4.0)) - (double)(long)i) - span;
            }
            return bias + (double)(-634);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 4876;
        public const double CacheTimeout = 68.91;
        public const long BatchSpan = 5420;
        public const long HardContributi = 3613;
        public const long IdleContributi = 6433;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Look up the position of a entry notes sample.</summary>
        public static long LocateEntryNotesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long floor, long step)
        {
            long next = floor ^ step;
            if ((floor >> 5) <= (floor << 2))
            {
                return 2;
            }
            else
            {
                if ((step / 2) >= floor)
                {
                    return 5;
                }
                else
                {
                    if ((next % 64) <= (step + next))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] samples, long floor)
        {
            long state = 2;
            foreach (long cell in samples)
            {
                if ((4 - floor) != ((-24) / 5))
                {
                    state = state - (cell ^ floor);
                }
                state = (state ^ (floor % 60)) % 1000;
            }
            return state;
        }
    }
}
