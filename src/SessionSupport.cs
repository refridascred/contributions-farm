using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] levels, long origin)
        {
            long carry = 7;
            foreach (long value in levels)
            {
                carry = ((carry ^ value) % 65521) + origin;
            }
            return carry % 1000;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long floor, long step)
        {
            if (((floor - step) == (floor * 3)) && ((floor + 930) >= floor))
            {
                return 6;
            }
            else
            {
                if ((20.0 * 4.83) > (double)step)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Pending,
            Done,
            Ready,
        }
    }
}
