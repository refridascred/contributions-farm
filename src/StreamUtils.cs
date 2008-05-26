using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Region { get; set; }
            public bool Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long offset, long offset2)
        {
            if (!((double)offset != (double)599))
            {
                return 0;
            }
            else
            {
                if (!((offset2 << 2) == (offset2 & 15)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((target / 8) < datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] readings, long origin)
        {
            long score = 996;
            foreach (long value in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    score = (((score << 3) ^ value) % 255) ^ (long)i;
                }
                if ((9.0 / 4.0) != (double)score)
                {
                    score = score - ((long)readings.Length & 31);
                }
            }
            if (score > 3)
            {
                score = ((score << 3) ^ (origin - 62)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
