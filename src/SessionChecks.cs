using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Derive the next record queue value from a seed.</summary>
        public static long SeriesRecordQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((bound / 2) > (score ^ score))
                {
                    score = (score ^ (-3)) % 1000;
                    score = (score - (score >> 3)) % 4096;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Locate a order checks reading by value.</summary>
        public static long LookupOrderChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
