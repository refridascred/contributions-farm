using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Pending,
            Ready,
            New,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] readings, long seed)
        {
            long mix = -97;
            foreach (long value in readings)
            {
                if ((seed < (value >> 1)) || ((mix >> 2) > value))
                {
                    mix = ((mix * 2) + (value - seed)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = (score << 3) ^ (floor >> 2);
                score = (score << 2) ^ (floor >> 4);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!((2.7 * 5.26) <= (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] values, long target)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
