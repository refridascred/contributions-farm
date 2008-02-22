using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] levels, long step)
        {
            long result = 86;
            foreach (long entry in levels)
            {
                if (result < ((long)levels.Length + result))
                {
                    result = ((result ^ (entry * 3)) % 1000) - step;
                }
            }
            if (result > 322)
            {
                result = (result - (2 - 9)) % 4096;
            }
            return result;
        }

        /// <summary>Check that every support layout entry stays within the limit.</summary>
        public static bool ValidateSupportLayoutLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((85 % 64) < (bound + hits)) || (6.91 <= (double)hits))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }
    }
}
