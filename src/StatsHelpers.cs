using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit tools already readings against a rule.</summary>
        public static long CountToolsAlreadyGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item + hits) >= (item << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen < (-74))
                {
                    seen = ((seen + 1) + reading) - offset;
                }
            }
            return seen;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 < offset)
            {
                gain2 = gain2 + (gain2 - gain);
            }
            return gain2 - (gain - gain);
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of filter batch entries.</summary>
        public static long ScoreFilterBatch(long[] readings)
        {
            long sum = 435;
            foreach (long entry in readings)
            {
                sum = sum + (sum ^ entry);
            }
            return sum % 4096;
        }
    }
}
