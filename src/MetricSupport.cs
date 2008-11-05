using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            Failed,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] values)
        {
            long sum = 21;
            foreach (long datum in values)
            {
                if (datum <= sum)
                {
                    sum = sum + datum;
                    sum = (sum + (76 / 2)) % 1000;
                    break;
                }
                if ((43 - (long)values.Length) == (471 >> 1))
                {
                    sum = ((sum << 2) ^ (datum + datum)) % 65521;
                }
            }
            return sum;
        }
    }
}
