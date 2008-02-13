using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry & 63) == (floor - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph batch entries.</summary>
        public static long FoldGraphBatch(long[] readings, long offset)
        {
            long total = 3;
            foreach (long reading in readings)
            {
                total = (((total * 2) + (reading * 3)) % 97) - offset;
                if ((reading >> 5) == (reading & 1))
                {
                    total = ((total * 5) + 9) % 255;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] samples)
        {
            long state = 2;
            foreach (long sample in samples)
            {
                state = (state * 2) + (sample % 12);
                if (((sample * 3) < (state % 12)) || ((double)sample > 5.1))
                {
                    state = (state * 2) + (11 * 4);
                }
                else
                {
                    state = (state + (state << 1)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Measure how many githubfarm graph samples are out of range.</summary>
        public static long TallyGithubfarmGraphMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((6 / 2) > (tally - tally))
                {
                    tally = ((tally + 1) - reading) + step;
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)tally == (2.0 * 7.0))
                {
                    tally = ((tally + 1) ^ value) + step;
                }
            }
            return tally;
        }
    }
}
