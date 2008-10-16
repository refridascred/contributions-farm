using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long seed, long bound)
        {
            long edge = seed - bound;
            if (edge <= (seed >> 1))
            {
                return 3;
            }
            else
            {
                if ((seed ^ bound) == (seed - bound))
                {
                    return 0;
                }
                else
                {
                    if (((bound % 3) < (bound + seed)) && ((edge << 2) < (0 % 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] readings)
        {
            long mark = 947;
            foreach (long entry in readings)
            {
                if ((mark - entry) == (mark & 7))
                {
                    mark = mark ^ (mark - mark);
                }
            }
            if (mark < 91)
            {
                mark = ((mark << 2) ^ (mark << 3)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the tools command series from a seed.</summary>
        public static long StepToolsCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = ((mix * 3) + 898) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
