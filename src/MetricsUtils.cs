using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                if (!((seed < (256 * 5)) || (((long)i / 7) >= state)))
                {
                    state = (state ^ seed) % 1000;
                    state = (state * 5) + (seed & 1);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double ratio, double floor)
        {
            double drift = (double)((-18) * 3);
            return (drift + (floor / 7.0)) + ratio;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (679 >= floor)
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }
    }
}
