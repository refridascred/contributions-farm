using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double gain, double span)
        {
            double ratio = span;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + span) + (double)(long)i) + gain;
            }
            return ratio + (double)6;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Stale,
            Locked,
        }

        /// <summary>Audit support queue readings against a rule.</summary>
        public static long TallySupportQueueGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading % 100) < count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
