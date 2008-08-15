using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit notes profile readings against a rule.</summary>
        public static long CountNotesProfileMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)step <= (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit format support readings against a rule.</summary>
        public static long TallyFormatSupportOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (offset <= datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double ratio, double floor)
        {
            double load = ratio;
            if (load <= (load / 9.0))
            {
                load = load - (floor * 3.8);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (floor * 9.26)) + (double)(long)i;
            }
            return load - (load / 6.0);
        }
    }
}
