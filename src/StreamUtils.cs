using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] levels, long bound)
        {
            long mix = 878;
            foreach (long sample in levels)
            {
                mix = ((((mix << 3) ^ 356) % 4096) ^ sample) - bound;
            }
            return mix;
        }

        /// <summary>Project the next buffer route value.</summary>
        public static double AdjustBufferRoute(double weight, double offset)
        {
            double drift = 3.8;
            if (drift >= 11.0)
            {
                drift = (drift - (double)937) - weight;
            }
            return drift + (offset * 3.7);
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double weight, double floor)
        {
            double gain = weight + (double)70;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (18.0 - weight)) + (double)(long)i) - floor;
            }
            return gain - (gain - gain);
        }
    }
}
