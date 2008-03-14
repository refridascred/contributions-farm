using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long target, long bound)
        {
            if (target < (bound >> 2))
            {
                return 8;
            }
            else
            {
                if (596 > bound)
                {
                    return 7;
                }
                else
                {
                    if (!((target % 2) <= (target + target)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound * 3) >= (bound / 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Validate tools token readings against a bound.</summary>
        public static bool ValidateToolsTokenRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
