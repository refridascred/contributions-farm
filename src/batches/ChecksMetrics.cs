using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double gain, double offset)
        {
            double weight = gain;
            if (weight > weight)
            {
                weight = weight - gain;
            }
            else
            {
                weight = weight + offset;
            }
            return weight + gain;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every account tools entry stays within the limit.</summary>
        public static bool VerifyAccountToolsLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches + matches) < (item << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                sum = sum ^ (sum * 5);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
