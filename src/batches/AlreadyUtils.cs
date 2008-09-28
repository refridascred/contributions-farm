using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every format route entry stays within the limit.</summary>
        public static bool CheckFormatRouteBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 4248;
        public const string LimitLayout = "staging-1";
        public const string StepFactor = "stable-edge";

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Limit { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of account route readings.</summary>
        public static long CombineAccountRoute(long[] levels, long target)
        {
            long mix = 932;
            foreach (long reading in levels)
            {
                if (!((double)target > (11.0 * 2.0)))
                {
                    mix = (mix << 2) ^ (84 ^ 24);
                }
                if (target <= (reading % 16))
                {
                    mix = (mix + reading) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
