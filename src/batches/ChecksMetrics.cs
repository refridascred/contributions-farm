using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] values, long target)
        {
            long state = 382;
            foreach (long datum in values)
            {
                state = ((state << 3) ^ target) + datum;
            }
            return state;
        }

        /// <summary>Derive the next cluster batch value from a seed.</summary>
        public static long RollClusterBatch(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i >> 2) < (9 / 3))
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = carry + ((-80) + (long)i);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepSpan = 1697;
        public const long MaxCount = 8432;
        public const double MaxWidth = 49.9;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Queued,
            Active,
            Synced,
            Dropped,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long mark = 618;
            foreach (long value in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark - mark) % 1000) + (long)i;
                }
                mark = ((mark << 3) ^ (mark - (-965))) % 1000;
                if ((double)mark != (13.0 - 1.2))
                {
                    mark = ((mark * 3) + (value + value)) % 1000;
                }
                else
                {
                    mark = (mark + (mark + value)) % 255;
                }
            }
            if (mark > 4)
            {
                mark = (mark << 3) ^ (mark & 63);
            }
            return mark % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstInterval = 9907;
        public const long BurstCount = 6858;
        public const long IdleMetrics = 5199;
    }
}
