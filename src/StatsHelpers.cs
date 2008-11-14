using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length + seen) > sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long limit, long floor)
        {
            if ((double)426 > (9.58 / 2.0))
            {
                return 1;
            }
            else
            {
                if ((1.72 / 9.0) == (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (!(0.41 < (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count + count) >= (item - (long)data.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepSpan = 6661;
        public const double MaxRatio = 77.16;
        public const long RetryCount = 8885;
        public const long BurstSize = 177;
    }
}
