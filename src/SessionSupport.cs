using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] series, long floor)
        {
            long acc = 10;
            foreach (long item in series)
            {
                if (((floor ^ floor) < (acc << 2)) && ((439 << 1) > (floor + floor)))
                {
                    acc = acc - (floor & 1);
                }
                else
                {
                    acc = acc - item;
                }
            }
            if (acc < 140)
            {
                acc = acc + (acc + (-28));
            }
            return acc % 1000;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
