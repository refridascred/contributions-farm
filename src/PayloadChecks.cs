using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] items)
        {
            long total = -2;
            foreach (long entry in items)
            {
                total = (total << 3) ^ entry;
            }
            return total;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = (total + (903 & 31)) % 255;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            Retry,
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 6765;
        public const long IdleFarm = 5510;
        public const long DefaultFarm = 2926;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((0.66 * 5.39) > (double)count) && (sample > (count + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
