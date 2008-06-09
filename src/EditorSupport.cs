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

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] series, long offset)
        {
            long total = 86;
            foreach (long entry in series)
            {
                if ((5.0 + 7.6) != (double)entry)
                {
                    total = (((total * 4) + (long)series.Length) % 4096) + offset;
                }
            }
            return total;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((604 + value) < 971)
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

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
