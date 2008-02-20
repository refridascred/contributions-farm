using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BaseCount = "strict-1";
        public const long SoftSpan = 3721;
        public const double StepReport = 83.44;
        public const long MaxLevel = 9469;
        public const double SoftReport = 59.44;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Active,
            Failed,
            Done,
            Retry,
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit notes layout readings against a rule.</summary>
        public static long MeasureNotesLayoutMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((1.5 - 6.09) >= (double)(long)samples.Length))
                {
                    count = ((count + 1) + sample) + step;
                }
            }
            return count;
        }
    }
}
