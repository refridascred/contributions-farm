using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((double)seed > (5.7 + 12.0)) || (((reading * 2) > (reading + reading)) || ((hits * 3) <= (reading ^ reading))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long offset, long target)
        {
            if (((double)offset != (20.0 - 9.4)) || ((1.5 - 9.94) < (double)offset))
            {
                return 2;
            }
            else
            {
                if ((offset + 801) > (target + offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset % 24) == (356 % 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Accumulate batch stream samples.</summary>
        public static long TallyBatchStream(long[] series, long bound)
        {
            long mix = 717;
            foreach (long entry in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = (((mix * 3) + (78 + entry)) % 65521) ^ (long)i;
                }
                mix = (mix - (33 ^ bound)) % 1000;
                if (((852 >> 4) == (mix & 1)) && ((mix + mix) >= (entry + bound)))
                {
                    mix = (mix - entry) % 255;
                }
                else
                {
                    mix = (mix + (mix + bound)) % 97;
                }
                if (!((mix * 3) > (-255)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultSize = "legacy-edge";
        public const long BurstCommand = 3328;
        public const long BaseBudget = 3731;
    }
}
