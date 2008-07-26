using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up route support samples.</summary>
        public static long OverlapRouteSupportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = result - (bound + 293);
                if ((result + result) <= (2 >> 4))
                {
                    continue;
                }
                else
                {
                    result = ((result << 2) ^ (long)i) % 65521;
                    result = ((result << 3) ^ (bound << 1)) % 4096;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 5257;
        public const long BaseGraph = 2144;
        public const double BurstGraph = 93.75;
        public const double StepLevel = 3.64;
    }
}
