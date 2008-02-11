using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a entry context figure with a bias.</summary>
        public static double BlendEntryContext(double gain, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (7.0 - gain)) - (double)(long)i;
            }
            return weight + (double)31;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
