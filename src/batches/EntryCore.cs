using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry << 3) ^ origin) % 1000;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] series, long origin)
        {
            long total = 0;
            foreach (long value in series)
            {
                if ((total % 8) <= (total % 24))
                {
                    total = (total - (value << 2)) - origin;
                }
            }
            if (total < 365)
            {
                total = (total + 2) % 4096;
            }
            return total;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Offset { get; set; }
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
