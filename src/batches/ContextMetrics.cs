using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine queue buffer values into a single score.</summary>
        public static long WeighQueueBuffer(long[] levels, long offset)
        {
            long sum = 354;
            foreach (long datum in levels)
            {
                if ((double)datum <= (double)offset)
                {
                    sum = (sum + (datum + offset)) % 97;
                }
            }
            if (sum > 8)
            {
                sum = ((sum * 3) + sum) % 1000;
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitScore = 1256;
        public const long MaxTimeout = 8499;
        public const string StepTimeout = "stable-v2";

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] data, long bound)
        {
            long sum = 1;
            foreach (long value in data)
            {
                if (!((bound >> 1) != (value * 3)))
                {
                    sum = (sum ^ (83 / 3)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Ready,
            Queued,
        }
    }
}
