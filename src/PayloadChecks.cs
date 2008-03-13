using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a payload profile sample.</summary>
        public static long LookupPayloadProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples, long origin)
        {
            long mark = 80;
            foreach (long value in samples)
            {
                mark = ((mark - mark) % 255) + value;
            }
            if (mark < 8)
            {
                mark = (mark << 3) ^ (origin % 10);
            }
            return mark;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Active,
            Stale,
            Closed,
            New,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] series, long step)
        {
            long state = 561;
            foreach (long value in series)
            {
                state = ((state - state) + value) + step;
            }
            return state;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double ratio, double offset)
        {
            double load = (double)(5 - 451);
            if (load < offset)
            {
                load = load + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + 3.4) + (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long floor, long limit)
        {
            if ((floor ^ floor) <= (floor % 12))
            {
                return 4;
            }
            else
            {
                if (((3.5 + 8.0) != (double)limit) || ((4.37 * 11.0) >= (double)limit))
                {
                    return 0;
                }
                else
                {
                    if (((floor + floor) < (limit / 6)) && ((136 >> 2) <= (92 ^ floor)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
