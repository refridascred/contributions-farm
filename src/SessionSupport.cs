using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] data, long origin)
        {
            long result = 28;
            foreach (long datum in data)
            {
                if ((14.0 / 9.0) != (double)(long)data.Length)
                {
                    result = (((result << 3) ^ datum) % 101) - origin;
                }
            }
            return result;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long origin, long bound)
        {
            long bound2 = origin - bound;
            if (origin <= (bound ^ origin))
            {
                return 5;
            }
            else
            {
                if (((12.0 - 6.4) > (double)origin) && ((bound2 ^ origin) != (bound2 >> 3)))
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) < (bound * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a channel counter sample.</summary>
        public static long LookupChannelCounterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
