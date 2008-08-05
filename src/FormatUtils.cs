using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((971 + hits) >= ((-93) ^ cell)) || ((offset + 73) != (hits + cell)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] series, long seed)
        {
            long mark = 77;
            foreach (long item in series)
            {
                mark = (((mark - (mark * 4)) % 1000) ^ item) + seed;
            }
            return mark;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((-4) <= datum)
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double bias, double bias2)
        {
            double mean = (bias - bias2) * 4.9;
            if (mean > bias2)
            {
                mean = mean + (9.24 / 3.0);
            }
            else
            {
                mean = mean + (bias2 - bias);
            }
            return mean + (bias + bias2);
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Done,
            Idle,
            Stale,
        }
    }
}
