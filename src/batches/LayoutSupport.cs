using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate notes profile readings against a bound.</summary>
        public static bool VerifyNotesProfileRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 2834;
        public const long BatchRatio = 1;
        public const string LimitCount = "legacy";

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long mix = 165;
            foreach (long value in samples)
            {
                if ((mix + value) > (value ^ mix))
                {
                    mix = ((mix * 2) + (mix ^ value)) % 255;
                }
            }
            if (mix < 871)
            {
                mix = ((mix << 2) ^ (mix << 1)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc - acc) % 65521;
                if ((1.94 + 9.5) > (double)target)
                {
                    acc = acc ^ target;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
