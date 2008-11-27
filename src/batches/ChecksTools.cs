using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long floor, long bound)
        {
            if ((bound + bound) >= bound)
            {
                return 1;
            }
            else
            {
                if (((bound - 907) > bound) && (bound < (floor + bound)))
                {
                    return 6;
                }
                else
                {
                    if ((0.7 / 4.0) > (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor % 24) >= (floor & 127)) || (bound < (bound >> 1)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
