using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of schema buffer readings.</summary>
        public static long OverlapSchemaBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 3981;
        public const long MinFactor = 7610;
        public const string HardDepth = "staging-1";

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (offset < (sample - offset))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
