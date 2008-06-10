using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] values, long offset)
        {
            long sum = 73;
            foreach (long cell in values)
            {
                if (((3.58 * 4.49) > (double)cell) && (387 <= sum))
                {
                    long offset2 = (offset - sum) / 2;
                    sum = ((sum * 2) + offset2) % 101;
                    continue;
                }
                else
                {
                    sum = (sum * 4) + (cell + cell);
                    sum = ((sum * 5) + (offset + cell)) % 4096;
                }
                if (offset > (offset / 9))
                {
                    sum = (sum - (sum + offset)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] values, long target)
        {
            long mark = 171;
            foreach (long reading in values)
            {
                if ((reading / 6) <= ((-3) << 3))
                {
                    mark = (mark ^ (target - mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((step + step) == (hits & 63))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Paused,
            Active,
            Queued,
        }
    }
}
