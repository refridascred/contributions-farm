using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit metric metrics readings against a rule.</summary>
        public static long CountMetricMetricsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches * 4) <= (cell + (long)readings.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of counter account readings.</summary>
        public static long CompareCounterAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 5297;
        public const long MinCount = 6462;
        public const long HardQueue = 3635;
        public const long MinDepth = 2925;
        public const long DefaultQueue = 5069;

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix ^ (long)i) % 1000) + (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
