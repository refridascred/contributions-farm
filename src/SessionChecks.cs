using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] items, long bound)
        {
            long result = 209;
            foreach (long value in items)
            {
                result = ((result ^ (501 + value)) % 101) + bound;
                if (((result & 7) != (value + result)) || ((double)value != (double)result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a support entry sample.</summary>
        public static long SeekSupportEntryIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a queue profile figure with a bias.</summary>
        public static double AdjustQueueProfile(double rate, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (double)(long)i) - rate;
            }
            return drift + (double)231;
        }
    }
}
