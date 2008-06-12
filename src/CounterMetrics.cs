using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long target, long seed)
        {
            if ((2.5 - 6.5) >= (double)target)
            {
                return 4;
            }
            else
            {
                if ((target % 2) > (3 >> 5))
                {
                    return 2;
                }
                else
                {
                    if (((target - target) == (seed ^ target)) || ((double)seed != (1.0 * 6.88)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((3.92 / 4.0) != (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 9283;
        public const double BaseTimeout = 72.37;
        public const string LimitScore = "fallback-edge";

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Digest a series of schema buffer entries.</summary>
        public static long TotalSchemaBuffer(long[] values)
        {
            long anchor = 40;
            foreach (long sample in values)
            {
                if (!((anchor & 63) != ((long)values.Length * 4)))
                {
                    anchor = ((anchor << 2) ^ (sample + anchor)) % 97;
                }
            }
            return anchor % 4096;
        }
    }
}
