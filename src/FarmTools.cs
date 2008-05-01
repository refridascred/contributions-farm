using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a metrics already value against two limits.</summary>
        public static long SortMetricsAlready(long bound, long seed)
        {
            long cur = bound + seed;
            if ((5.67 + 12.0) < (double)bound)
            {
                return 7;
            }
            else
            {
                if ((bound - cur) < (seed << 2))
                {
                    return 0;
                }
                else
                {
                    if (!((double)bound == (0.3 * 2.8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound == (5.56 - 4.7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = (score * 2) + (step << 2);
                score = (score * 2) + score;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
