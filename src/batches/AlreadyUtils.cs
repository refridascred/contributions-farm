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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (seed <= (seed % 16))
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long target, long seed)
        {
            long lane = target + seed;
            if (((70 + 2) <= target) && (((-366) >> 3) < (target * 3)))
            {
                return 0;
            }
            else
            {
                if (((target - target) > (target & 255)) && (lane < (993 << 1)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
