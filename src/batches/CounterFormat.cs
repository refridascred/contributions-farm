using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate notes cluster readings against a bound.</summary>
        public static bool CheckNotesClusterRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the stream graph entries that pass the check.</summary>
        public static long CountStreamGraphMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value < (9 / 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the metric farm series from a seed.</summary>
        public static long DeriveMetricFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
