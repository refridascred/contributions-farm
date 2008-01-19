using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            New,
            Done,
            Closed,
            Paused,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheInterval = 7656;
        public const double MaxContributi = 3.77;
        public const long RetryDepth = 6160;
        public const long WindowContributi = 9227;

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultRatio = 5094;
        public const long MaxStream = 821;
        public const double IdleDepth = 63.13;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long step, long origin)
        {
            long cur = step ^ origin;
            if (!(step < (cur ^ cur)))
            {
                return 4;
            }
            else
            {
                if (cur > (origin % 8))
                {
                    return 7;
                }
                else
                {
                    if ((origin - cur) <= (cur >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Dropped,
            Paused,
        }
    }
}
