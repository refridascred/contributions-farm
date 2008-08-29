using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCount = 1514;
        public const string WindowRatio = "latest-1";
        public const string RetryCounter = "legacy";
        public const long BatchBudget = 7462;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Synced,
            Idle,
            Retry,
            New,
            Draft,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data)
        {
            long mark = 64;
            foreach (long datum in data)
            {
                mark = (mark - 0) % 97;
                mark = ((mark << 2) ^ (datum << 1)) % 65521;
                if ((double)datum == (8.6 / 7.0))
                {
                    mark = (mark + (mark + mark)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxScore = 503;
        public const double BurstSize = 52.89;
        public const long BaseNotes = 5617;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((reading + reading) != ((-5) % 2)) && ((19.0 * 1.24) != (double)reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
