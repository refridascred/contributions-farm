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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen % 24) > step)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
