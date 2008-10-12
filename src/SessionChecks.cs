using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of already batches readings.</summary>
        public static long FoldAlreadyBatches(long[] readings, long target)
        {
            long sum = 9;
            foreach (long datum in readings)
            {
                sum = sum + datum;
                if ((double)target <= (19.0 * 5.5))
                {
                    break;
                }
            }
            if (sum > 857)
            {
                sum = (sum << 2) ^ (target >> 4);
            }
            return sum % 65521;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Closed,
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double gain, double floor)
        {
            double scale = (double)((-407) & 31);
            if (scale < (double)818)
            {
                scale = (scale - 18.0) - gain;
            }
            else
            {
                scale = scale - (scale * 5.3);
            }
            return scale + floor;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
