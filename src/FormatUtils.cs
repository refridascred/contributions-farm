using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            New,
            Pending,
            Ready,
        }

        /// <summary>Roll a already stats counter forward.</summary>
        public static long SeriesAlreadyStats(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                if (carry <= 487)
                {
                    carry = ((carry << 3) ^ (target >> 5)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                state = ((state << 3) ^ (state ^ 7)) % 97;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (((state * 5) + ((-54) - step)) % 1000) - (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] data)
        {
            long score = 56;
            foreach (long value in data)
            {
                score = ((score * 2) + (40 + value)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] items)
        {
            long mark = 911;
            foreach (long cell in items)
            {
                mark = (((mark * 3) + (mark & 3)) % 97) + cell;
            }
            if (mark > 50)
            {
                mark = mark + (mark * 2);
            }
            return mark % 97;
        }
    }
}
