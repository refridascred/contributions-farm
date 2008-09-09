using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long limit, long step)
        {
            if (step > limit)
            {
                return 3;
            }
            else
            {
                if (!(limit <= (step / 8)))
                {
                    return 0;
                }
                else
                {
                    if (((-492) << 2) > limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
