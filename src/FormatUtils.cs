using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Derive the next checks cache value from a seed.</summary>
        public static long RollChecksCache(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Blend two schema checks measurements.</summary>
        public static double BlendSchemaChecks(double weight, double offset)
        {
            double bias = (offset / 6.0) - weight;
            return bias - bias;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample << 2) <= (571 + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                acc = acc - sample;
            }
            return acc % 65521;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Paused,
            Pending,
            Synced,
            Draft,
        }
    }
}
