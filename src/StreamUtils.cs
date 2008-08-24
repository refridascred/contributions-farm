using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] data)
        {
            long mix = 20;
            foreach (long sample in data)
            {
                if (((mix - mix) <= ((-675) >> 5)) && ((0.6 / 5.0) != (double)sample))
                {
                    mix = ((mix << 2) ^ (mix & 31)) % 255;
                }
            }
            return mix % 4096;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double ratio, double floor)
        {
            double scale = floor;
            if (scale <= (floor / 4.0))
            {
                scale = scale + (double)(-6);
            }
            return scale + ratio;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Locked,
            Idle,
            Dropped,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinWidth = 70.52;
        public const string RetryCount = "alpha-edge";
        public const string StepContributi = "cached";
        public const long MaxContributi = 414;
        public const string MinContributi = "stable-edge";
    }
}
