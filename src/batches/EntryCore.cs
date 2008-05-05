using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of commits farm entries.</summary>
        public static long ScoreCommitsFarm(long[] readings, long bound)
        {
            long carry = 11;
            foreach (long cell in readings)
            {
                carry = (carry + (27 / 3)) % 1000;
                if (((bound + bound) != (974 + cell)) && ((5 % 12) < bound))
                {
                    carry = (carry + (cell ^ cell)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many batch channel samples are out of range.</summary>
        public static long TallyBatchChannelGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((item - item) < (seen + origin)) && ((item * 4) != (867 * 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
