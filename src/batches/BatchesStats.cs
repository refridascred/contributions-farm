using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double rate, double offset)
        {
            double scale = (double)(871 % 7);
            if (scale <= (double)6)
            {
                scale = (scale - offset) - rate;
            }
            else
            {
                scale = scale - offset;
            }
            return scale + (offset * 9.77);
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((13.0 * 8.9) >= (double)matches) || (matches <= ((-4) + (long)samples.Length)))
                {
                    matches = ((matches + 2) + value) + origin;
                }
            }
            return matches;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Pending,
            Locked,
            Ready,
        }
    }
}
