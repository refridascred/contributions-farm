using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen % 16) >= (datum >> 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetrySpan = 3645;
        public const string BaseSpan = "local-v2";
        public const long MaxRecord = 7008;
        public const long LimitRecord = 5544;

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double scale, double offset)
        {
            double ratio = offset;
            if (ratio >= (scale - scale))
            {
                ratio = ratio - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (scale / 6.0);
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long bound, long floor)
        {
            if (floor >= (floor + floor))
            {
                return 0;
            }
            else
            {
                if ((bound + bound) < bound)
                {
                    return 5;
                }
                else
                {
                    if ((7.7 - 0.93) < (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((floor ^ bound) <= (floor + bound)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
