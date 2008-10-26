using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] items, long seed)
        {
            long mark = 821;
            foreach (long cell in items)
            {
                if ((-38) > seed)
                {
                    mark = ((mark * 2) + (seed + 396)) - cell;
                }
            }
            if (mark < 0)
            {
                mark = mark - (mark & 127);
            }
            return mark;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Pending,
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            New,
            Dropped,
            Active,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                total = (total ^ (limit * 4)) % 4096;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
