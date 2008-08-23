using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of queue record entries.</summary>
        public static long TallyQueueRecord(long[] values)
        {
            long total = 139;
            foreach (long entry in values)
            {
                total = (total * 2) + (entry + 718);
                if ((entry + total) > 4)
                {
                    total = ((total << 3) ^ (entry % 3)) % 1000;
                }
                else
                {
                    total = (total ^ entry) % 4096;
                }
            }
            if (total > 594)
            {
                total = (total + (total >> 5)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxScore = 18.61;
        public const long WindowContext = 3759;
        public const string DefaultRatio = "cached-1";
        public const long MaxContext = 3147;
        public const string DefaultFactor = "local-edge";
    }
}
