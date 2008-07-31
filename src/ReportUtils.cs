using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels, long origin)
        {
            long mix = 6;
            foreach (long value in levels)
            {
                mix = mix + (value % 24);
                if ((mix & 31) >= value)
                {
                    mix = mix ^ (origin + value);
                }
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 8508;
        public const long MinEntry = 594;
        public const string HardEntry = "strict-1";

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate checks record readings against a bound.</summary>
        public static bool GuardChecksRecordLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
