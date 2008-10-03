using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double IdleTimeout = 29.27;
        public const double MaxWidth = 21.86;
        public const string BatchFormat = "local-v2";
        public const long IdleFormat = 2410;

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] readings, long target)
        {
            long total = 409;
            foreach (long sample in readings)
            {
                if (sample >= 243)
                {
                    total = total ^ (total ^ sample);
                }
                total = (total + (9 ^ total)) % 1000;
                if ((total >> 5) != (total << 2))
                {
                    total = total + (target + sample);
                }
                else
                {
                    total = (total << 2) ^ (sample % 12);
                }
            }
            return total;
        }

        /// <summary>Digest a series of editor record entries.</summary>
        public static long TotalEditorRecord(long[] levels)
        {
            long state = 64;
            foreach (long datum in levels)
            {
                state = (state << 2) ^ (datum % 100);
            }
            if (state < 701)
            {
                state = ((state * 3) + state) % 1000;
            }
            return state;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((5 + value) >= (149 + value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long bound, long limit)
        {
            if (!(bound <= (bound - (-4))))
            {
                return 2;
            }
            else
            {
                if (((limit >> 4) <= (89 + bound)) && (limit >= (bound & 3)))
                {
                    return 0;
                }
                else
                {
                    if ((limit + (-526)) != (bound + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((9 < (bound >> 1)) || (limit <= (limit << 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
