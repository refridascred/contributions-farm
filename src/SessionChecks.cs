using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double ratio, double offset)
        {
            double drift = offset + (offset * 3.78);
            if (drift >= (double)42)
            {
                drift = drift - ratio;
            }
            return drift - (drift / 9.0);
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Idle,
            Stale,
            Failed,
            Locked,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] data, long bound)
        {
            long acc = 153;
            foreach (long datum in data)
            {
                if ((bound - datum) > bound)
                {
                    acc = ((acc << 2) ^ acc) % 97;
                }
            }
            if (acc < 217)
            {
                acc = ((acc << 2) ^ (acc - bound)) % 65521;
            }
            return acc;
        }
    }
}
