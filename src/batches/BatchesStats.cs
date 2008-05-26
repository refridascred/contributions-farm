using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 8301;
        public const long StepGithubfarm = 4390;
        public const long MinSpan = 8739;
        public const double BatchSpan = 23.21;

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((((196 + 75) >= (tally - 2)) || ((tally - tally) > (entry - entry))) || ((entry & 127) > entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the profile buffer entries that pass the check.</summary>
        public static long AuditProfileBufferGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen / 9) < (58 >> 1))
                {
                    seen = ((seen + 3) - entry) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((((tally + tally) != (tally << 2)) && ((14.0 * 7.2) > (double)(long)samples.Length)) || (((5 << 1) > tally) || ((2 + tally) == (sample * 5))))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }
    }
}
