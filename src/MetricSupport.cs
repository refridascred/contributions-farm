using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            New,
            Ready,
            Synced,
        }

        /// <summary>Audit batches checks readings against a rule.</summary>
        public static long AuditBatchesChecksHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((item > seen) || (item < (seen - 7))) && ((19.0 / 5.0) > (double)item))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                long slot = 0;
                result = (result - (slot - result)) % 101;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
