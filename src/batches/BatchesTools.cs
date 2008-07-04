using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings)
        {
            long mix = -619;
            foreach (long value in readings)
            {
                if (!(549 <= (value + mix)))
                {
                    mix = (mix + (57 << 2)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Count the report counter entries that pass the check.</summary>
        public static long CountReportCounterGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)bound > 5.47)
                {
                    matches = (matches + 2) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
