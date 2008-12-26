using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((hits % 24) <= datum) && ((double)datum >= (double)hits)) && ((169 << 1) <= hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank schema order input into a small class.</summary>
        public static long ClassifySchemaOrder(long seed, long bound)
        {
            if ((seed - bound) >= (bound % 24))
            {
                return 0;
            }
            else
            {
                if (((seed - seed) >= (seed + 90)) || ((0.7 - 3.0) <= (double)bound))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 1803;
        public const string WindowFactor = "legacy-1";
        public const long DefaultTimeout = 8793;
        public const long BaseCluster = 2533;
        public const long IdleCluster = 6866;
    }
}
