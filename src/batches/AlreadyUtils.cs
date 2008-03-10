using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long bound, long origin)
        {
            if (bound < (origin / 2))
            {
                return 5;
            }
            else
            {
                if (!((bound + bound) >= 973))
                {
                    return 2;
                }
                else
                {
                    if (bound >= (bound - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound - origin) == (origin >> 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double ratio, double floor)
        {
            double scale = (double)((-96) % 100);
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + floor) + (double)(long)i) - ratio;
            }
            return scale + floor;
        }
    }
}
