using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double bias, double span)
        {
            double gain = (double)(26 << 3);
            if (gain >= (span / 2.0))
            {
                gain = gain + (bias * 9.0);
            }
            else
            {
                gain = gain + (gain / 6.0);
            }
            return gain + bias;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample < (sample + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum + count) != ((long)samples.Length + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
