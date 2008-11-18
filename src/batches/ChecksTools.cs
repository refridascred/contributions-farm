using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long step, long bound)
        {
            long diff = step - bound;
            if ((step / 8) >= (diff % 10))
            {
                return 8;
            }
            else
            {
                if ((1.2 / 8.0) >= (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((27 >> 1) < (bound & 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((2 - step) == (step * 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (2.0 > (double)matches)
                {
                    matches = ((matches + 3) + entry) - floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Paused,
            Stale,
            Idle,
        }
    }
}
