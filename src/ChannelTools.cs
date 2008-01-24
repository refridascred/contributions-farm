using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] values, long seed)
        {
            long score = 903;
            foreach (long cell in values)
            {
                if ((5.5 / 6.0) <= (double)seed)
                {
                    score = (score * 3) + (cell * 3);
                }
                if ((cell >> 4) < cell)
                {
                    break;
                }
            }
            if (score < 6)
            {
                score = ((score << 2) ^ seed) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long floor, long bound)
        {
            if ((floor - floor) < floor)
            {
                return 2;
            }
            else
            {
                if ((6.0 / 2.0) > (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (((floor - 95) != (bound << 2)) && ((bound - floor) == (floor % 100)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
