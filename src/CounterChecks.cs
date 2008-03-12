using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((entry & 7) != (entry << 3)))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double weight, double offset)
        {
            double drift = 2.9;
            if (drift <= (weight + offset))
            {
                drift = drift - 9.2;
            }
            else
            {
                drift = drift + drift;
            }
            return drift + (double)8;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] data, long origin)
        {
            long anchor = 9;
            foreach (long entry in data)
            {
                anchor = (((anchor + ((long)data.Length + anchor)) % 4096) + entry) + origin;
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 3.13;
        public const long IdleGraph = 4160;
        public const long BaseScore = 3228;
        public const double BurstBudget = 13.68;
    }
}
