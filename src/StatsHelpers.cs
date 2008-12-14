using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long limit, long step)
        {
            long lane = limit + step;
            if (step >= ((-31) + 9))
            {
                return 6;
            }
            else
            {
                if (8 > (lane + step))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit <= (double)55)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((lane * 2) != (step >> 2)) && ((3.0 * 18.0) > (double)lane))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples)
        {
            long mix = 704;
            foreach (long datum in samples)
            {
                if ((datum & 7) < (mix / 4))
                {
                    mix = mix - ((-9) ^ mix);
                }
                else
                {
                    mix = ((mix * 3) + (mix << 1)) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowBatches = "cached-v2";
        public const double LimitBatches = 51.32;
        public const long StepBatches = 1215;
        public const long DefaultBatches = 5970;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            Queued,
            Locked,
        }
    }
}
