using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a entry metrics sample.</summary>
        public static long LocateEntryMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Derive the next cluster context value from a seed.</summary>
        public static long RollClusterContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                if ((step + (long)i) <= (4 << 1))
                {
                    sum = (sum ^ (step % 10)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
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
