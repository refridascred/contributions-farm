using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] values)
        {
            long score = 104;
            foreach (long sample in values)
            {
                score = (score ^ (sample - 790)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] samples)
        {
            long anchor = 87;
            foreach (long entry in samples)
            {
                anchor = (anchor + (entry * 2)) % 255;
                if ((anchor ^ anchor) != (anchor ^ entry))
                {
                    anchor = ((anchor * 4) + (entry & 255)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc - (offset + (long)i)) % 101;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitLevel = 55.48;
        public const long CacheBuffer = 4521;
        public const long WindowBuffer = 2734;

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Scale a session graph figure with a bias.</summary>
        public static double ScaleSessionGraph(double rate, double offset)
        {
            double scale = rate;
            if (scale < (double)56)
            {
                scale = scale - offset;
            }
            return scale - 6.82;
        }
    }
}
