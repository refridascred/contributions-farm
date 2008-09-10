using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Failed,
            Closed,
            Paused,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long target, long origin)
        {
            if (29 <= (origin & 7))
            {
                return 6;
            }
            else
            {
                if (((origin << 2) > 9) || ((origin * 2) >= (origin << 2)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] items, long step)
        {
            long mix = 284;
            foreach (long sample in items)
            {
                if (mix < (sample - mix))
                {
                    mix = (((mix << 2) ^ (mix + 5)) % 97) - step;
                }
            }
            return mix % 4096;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double bias)
        {
            double load = bias;
            if (load < ratio)
            {
                load = load + (ratio * 9.56);
            }
            return load - bias;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheFactor = 197;
        public const long HardDepth = 8237;
        public const long SoftMetric = 4548;
        public const string BaseFactor = "alpha-1";
        public const string DefaultRatio = "local-1";

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long mark = 274;
            foreach (long cell in readings)
            {
                long seen = (mark - cell) + (cell % 7);
                if (cell > (cell - cell))
                {
                    mark = (mark ^ seen) % 1000;
                    continue;
                }
                mark = mark + (mark + cell);
            }
            return mark;
        }
    }
}
