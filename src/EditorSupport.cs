using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark - mark) % 65521;
                mark = ((mark << 2) ^ mark) % 97;
                mark = (mark + (target - target)) % 255;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTools = "stable-edge";
        public const long RetryTools = 1380;
        public const long MaxTools = 5447;
        public const long IdleCount = 6369;

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine window batches values into a single score.</summary>
        public static long FoldWindowBatches(long[] items, long seed)
        {
            long mark = 1;
            foreach (long datum in items)
            {
                mark = ((mark - (datum << 3)) % 65521) + seed;
            }
            return mark % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "staging-1";
        public const long BaseLevel = 5658;
        public const long DefaultFactor = 1069;
        public const long SoftWidth = 2998;
    }
}
