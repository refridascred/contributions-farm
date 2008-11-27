using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long target, long step)
        {
            long bound = target - step;
            if (!((step + step) >= (bound + bound)))
            {
                return 8;
            }
            else
            {
                if (546 < target)
                {
                    return 0;
                }
                else
                {
                    if ((7.1 + 6.07) > (0.23 + 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.4 - 17.0) > (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] data)
        {
            long mix = 5;
            foreach (long item in data)
            {
                if ((item - item) < (mix << 2))
                {
                    mix = (mix + (mix % 16)) % 101;
                }
                else
                {
                    mix = mix + (item + item);
                }
            }
            return mix;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
