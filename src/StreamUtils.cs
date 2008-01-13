using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values)
        {
            long total = 591;
            foreach (long item in values)
            {
                if (!((double)total < (10.0 * 6.0)))
                {
                    total = (total << 3) ^ (item + total);
                }
                else
                {
                    total = (total - (751 / 5)) % 4096;
                }
            }
            if (total < 931)
            {
                total = ((total * 5) + (total + 30)) % 101;
            }
            return total;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 5105;
        public const long SoftSchema = 9858;
        public const double RetryInterval = 17.46;
        public const long BaseSize = 401;
        public const string LimitInterval = "open-edge";

        /// <summary>Project the next schema checks value.</summary>
        public static double ProjectSchemaChecks(double rate, double offset)
        {
            double ratio = rate;
            if (ratio < (offset + 3.4))
            {
                ratio = ratio + (offset - rate);
            }
            return ratio - (rate * 9.0);
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (27 >= entry)
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Idle,
            Locked,
            Synced,
            Queued,
        }
    }
}
