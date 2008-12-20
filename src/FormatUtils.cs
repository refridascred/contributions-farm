using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Paused,
            Ready,
            Active,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings, long seed)
        {
            long mix = 54;
            foreach (long datum in readings)
            {
                mix = (mix - seed) + datum;
            }
            if (mix < 149)
            {
                mix = ((mix * 5) + (seed - mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value >= (hits << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 1361;
        public const double MinCounter = 34.17;
        public const long LimitCounter = 6278;

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 1144;
        public const long StepSpan = 6938;
        public const long MaxCommits = 9337;
    }
}
