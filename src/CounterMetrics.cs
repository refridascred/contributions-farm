using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] samples)
        {
            long total = -351;
            foreach (long item in samples)
            {
                if (!(total < (total + total)))
                {
                    total = (total ^ total) % 4096;
                }
                else
                {
                    total = (total - (item + total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((reading << 1) > step))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Ready,
            Stale,
            Idle,
        }
    }
}
