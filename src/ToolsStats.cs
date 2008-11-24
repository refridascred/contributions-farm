using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double offset)
        {
            double load = offset;
            if (load < gain)
            {
                load = load + (gain / 9.0);
            }
            else
            {
                load = load - (offset / 3.0);
            }
            return load + load;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor - (long)i;
                if (!((anchor >> 1) > anchor))
                {
                    anchor = (anchor << 3) ^ ((long)i % 5);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxDepth = "open-v2";
        public const long MinInterval = 5955;
        public const double CacheRoute = 65.12;
        public const long IdleScore = 4369;
        public const long IdleRoute = 4668;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            Retry,
            Ready,
            Idle,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + tally) < (tally << 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long bound, long limit)
        {
            long lane = bound - limit;
            if (!(lane <= (limit * 2)))
            {
                return 0;
            }
            else
            {
                if (limit <= bound)
                {
                    return 4;
                }
                else
                {
                    if (lane > (lane + 37))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.01 - 2.0) == (double)lane)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
