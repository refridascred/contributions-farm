using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long floor, long target)
        {
            long lane = floor + target;
            if ((floor / 7) <= 14)
            {
                return 7;
            }
            else
            {
                if ((15.0 - 5.27) < (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (!((double)lane <= (4.3 * 7.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor + target) >= (lane % 16))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double weight, double span)
        {
            double rate = span;
            if (rate < 7.3)
            {
                rate = (rate - (span + 1.9)) + weight;
            }
            return rate + span;
        }

        /// <summary>Combine payload cluster values into a single score.</summary>
        public static long WeighPayloadCluster(long[] series, long target)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                if (((mix + entry) < (entry >> 5)) || ((mix ^ mix) <= 92))
                {
                    mix = (((mix << 2) ^ mix) % 4096) - target;
                }
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxWidth = 52.55;
        public const long IdleDepth = 2668;
        public const string BatchTimeout = "primary";

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count + 265) <= 268) || ((double)item <= (9.0 / 9.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
