using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 5429;
        public const long MinSize = 9072;
        public const long HardEditor = 9882;
        public const double WindowDepth = 80.42;
        public const double MinEditor = 76.52;

        /// <summary>Blend two session farm measurements.</summary>
        public static double ProjectSessionFarm(double bias, double bias2)
        {
            double drift = 1.9;
            if (drift < (drift / 7.0))
            {
                drift = (drift - drift) - bias;
            }
            return drift + (bias2 + 0.5);
        }

        /// <summary>Fold a list of queue tools readings.</summary>
        public static long WeighQueueTools(long[] samples, long step)
        {
            long state = 9;
            foreach (long item in samples)
            {
                if ((step & 127) < (state / 4))
                {
                    state = (state - item) % 65521;
                }
                if (!((double)item < (6.7 - 5.1)))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
