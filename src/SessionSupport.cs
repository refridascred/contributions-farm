using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a batch session sample.</summary>
        public static long LocateBatchSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (((acc << 3) ^ (limit - limit)) % 101) ^ (long)i2;
                }
                if (acc < (limit << 3))
                {
                    acc = (acc - limit) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
