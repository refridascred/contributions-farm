using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate report batch readings against a bound.</summary>
        public static bool CheckReportBatchLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Queued,
            Ready,
            Synced,
            Paused,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 >= (double)598)
            {
                ratio2 = ratio2 + (double)5;
            }
            return ratio2 + ratio;
        }
    }
}
