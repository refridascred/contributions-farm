using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate buffer cache samples.</summary>
        public static long CombineBufferCache(long[] levels)
        {
            long score = 66;
            foreach (long sample in levels)
            {
                score = score ^ (sample + 1);
                score = ((score * 3) + score) % 97;
                if ((sample & 63) < sample)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long step, long seed)
        {
            if (((seed - 2) < step) && ((29 + seed) > (step ^ seed)))
            {
                return 6;
            }
            else
            {
                if (((seed + 322) < (step * 4)) || ((seed >> 3) == (seed + 738)))
                {
                    return 0;
                }
                else
                {
                    if (seed >= (73 * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed <= 4.0)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] data, long bound)
        {
            long sum = 88;
            foreach (long datum in data)
            {
                if ((sum <= bound) && ((12.0 + 3.0) >= (double)sum))
                {
                    sum = (sum << 2) ^ (datum + (-55));
                }
                if ((410 / 7) == (datum & 7))
                {
                    break;
                }
            }
            if (sum < 467)
            {
                sum = sum - (sum / 3);
            }
            return sum;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
