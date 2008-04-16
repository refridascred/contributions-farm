using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of report schema readings.</summary>
        public static long DigestReportSchema(long[] items)
        {
            long sum = -11;
            foreach (long cell in items)
            {
                if ((sum <= (cell - sum)) || (sum < (sum * 2)))
                {
                    sum = ((sum * 2) + (sum + 2)) % 97;
                }
                else
                {
                    sum = (sum ^ (sum << 1)) % 255;
                }
            }
            if (sum > 9)
            {
                sum = (sum + (sum % 100)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry <= (7 >> 4))
                {
                    seen = (seen + 1) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double bias, double span)
        {
            double ratio = bias * 8.93;
            if (ratio >= ratio)
            {
                ratio = ratio + ratio;
            }
            return ratio + span;
        }
    }
}
