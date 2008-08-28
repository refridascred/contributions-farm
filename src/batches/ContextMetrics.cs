using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Ready,
            New,
            Dropped,
            Draft,
        }

        /// <summary>Blend two cluster stream measurements.</summary>
        public static double AdjustClusterStream(double ratio, double offset)
        {
            double load = (offset + 3.8) + 9.0;
            if (load > 7.31)
            {
                load = (load + (double)940) + ratio;
            }
            else
            {
                load = load + offset;
            }
            return load + (double)6;
        }

        /// <summary>Digest a series of command report entries.</summary>
        public static long TallyCommandReport(long[] items)
        {
            long mix = 779;
            foreach (long item in items)
            {
                if ((double)mix >= 2.0)
                {
                    mix = ((mix << 2) ^ (mix << 3)) % 101;
                    break;
                }
                mix = (mix ^ (mix + item)) % 4096;
            }
            if (mix < 9)
            {
                mix = mix ^ (mix % 64);
            }
            return mix % 4096;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((double)count > 11.0) || ((double)sample == (4.0 * 2.54))) || ((double)sample <= (1.1 * 0.5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Failed,
            Idle,
            New,
            Locked,
        }
    }
}
