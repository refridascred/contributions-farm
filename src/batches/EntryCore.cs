using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] items, long floor)
        {
            long mix = -433;
            foreach (long sample in items)
            {
                mix = (mix ^ (sample + mix)) % 97;
                if (76 > (26 ^ floor))
                {
                    mix = mix ^ (1 + (-9));
                }
            }
            return mix;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up batch graph samples.</summary>
        public static long OverlapBatchGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double scale, double bias)
        {
            double load = scale;
            if (load >= scale)
            {
                load = load + (bias * 1.0);
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load - 0.4;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell == (1.0 - 10.0))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }
    }
}
