using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc * 2) + seed;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((carry < (floor + carry)) && ((floor % 3) >= floor))
                {
                    carry = carry - (floor / 4);
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Locked,
            Done,
            Synced,
            Pending,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit entry session readings against a rule.</summary>
        public static long MeasureEntrySessionOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (seen <= (-92))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }
    }
}
