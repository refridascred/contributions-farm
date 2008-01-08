using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 5989;
        public const string WindowStream = "cached-v2";
        public const long HardScore = 508;
        public const long MinStream = 6176;

        /// <summary>Check that every support context entry stays within the limit.</summary>
        public static bool ValidateSupportContextBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFactor = 9074;
        public const string BatchDepth = "legacy-edge";
        public const long WindowFilter = 2296;

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                long lane = mark / 8;
                if ((lane + mark) < (4 ^ lane))
                {
                    lane = lane + (-8);
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
