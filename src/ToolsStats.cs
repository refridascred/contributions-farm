using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double bias, double bias2)
        {
            double gain = bias2;
            if (gain >= (bias2 * 1.0))
            {
                gain = gain - (bias * 6.3);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (gain + bias)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] series)
        {
            long acc = -736;
            foreach (long entry in series)
            {
                if ((double)66 < (double)entry)
                {
                    acc = (acc - (entry ^ entry)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Locked,
            Ready,
            Done,
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + (-7)) != (offset + offset))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the tools payload series from a seed.</summary>
        public static long SeriesToolsPayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                state = state + (state % 5);
                state = state ^ (limit % 7);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
