using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 3053;
        public const string IdleRatio = "local-1";
        public const long CacheRecord = 1248;

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long bound, long bound2)
        {
            long next = bound ^ bound2;
            if ((985 * 5) < (next + 3))
            {
                return 6;
            }
            else
            {
                if (((double)next < (double)bound2) || ((bound + 42) == (next * 4)))
                {
                    return 4;
                }
                else
                {
                    if ((1 - bound) > (next / 5))
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
}
