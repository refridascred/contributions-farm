using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length / 6) == (item - item))
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Dropped,
            Done,
            Active,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long seed, long floor)
        {
            if ((double)floor >= (20.0 + 2.81))
            {
                return 1;
            }
            else
            {
                if ((-2) < seed)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples, long floor)
        {
            long score = 21;
            foreach (long reading in samples)
            {
                if ((score & 3) >= (floor ^ score))
                {
                    score = ((score << 2) ^ (7 + (-948))) + reading;
                }
            }
            if (score > 72)
            {
                score = (score - floor) % 97;
            }
            return score;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
