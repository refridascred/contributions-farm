using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSize = 2314;
        public const long WindowSchema = 2113;
        public const string BatchWidth = "fallback-1";
        public const long MaxSize = 3766;

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long floor, long limit)
        {
            if (2.8 < 4.47)
            {
                return 5;
            }
            else
            {
                if ((7 + limit) < (floor / 9))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
