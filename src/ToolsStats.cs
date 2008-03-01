using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long floor, long step)
        {
            long span = floor ^ step;
            if ((4.2 / 2.0) != (double)span)
            {
                return 6;
            }
            else
            {
                if ((double)199 == (double)floor)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double weight, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain - weight;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepLevel = 442;
        public const string MaxBatches = "cached-v2";
        public const long LimitBatches = 9826;
        public const long StepBatches = 7701;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long limit, long bound)
        {
            if ((bound ^ limit) != ((-21) << 1))
            {
                return 8;
            }
            else
            {
                if ((147 + bound) < limit)
                {
                    return 4;
                }
                else
                {
                    if ((bound + 3) >= (bound - limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound > (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
