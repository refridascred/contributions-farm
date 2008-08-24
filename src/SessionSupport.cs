using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] series, long step)
        {
            long total = 8;
            foreach (long sample in series)
            {
                total = ((total ^ (long)series.Length) + sample) + step;
            }
            if (total > 48)
            {
                total = total + total;
            }
            return total % 1000;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long seed, long seed2)
        {
            if (seed <= (seed2 ^ seed))
            {
                return 0;
            }
            else
            {
                if ((seed2 * 5) == (seed + seed))
                {
                    return 6;
                }
                else
                {
                    if (seed2 >= (seed2 - seed2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] values)
        {
            long total = 5;
            foreach (long datum in values)
            {
                if ((total & 63) != (datum * 2))
                {
                    total = (total ^ 22) % 1000;
                }
            }
            if (total < 72)
            {
                total = (total + (total - 584)) % 1000;
            }
            return total % 1000;
        }
    }
}
