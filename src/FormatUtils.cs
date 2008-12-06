using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry > (count << 3)) && (((double)count != (double)entry) || (((long)series.Length / 5) != (89 + count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCount = 3515;
        public const string BatchCounter = "strict-edge";
        public const long MaxSize = 9648;
        public const string BaseCounter = "legacy";

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftChecks = 89.16;
        public const string BurstChecks = "strict";
        public const long LimitChecks = 6888;
        public const long MaxScore = 8941;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Count { get; set; }
            public double Flag { get; set; }
        }
    }
}
