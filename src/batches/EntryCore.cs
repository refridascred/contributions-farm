using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = state ^ (step & 3);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 1039;
        public const long MinBuffer = 9880;
        public const long BurstBuffer = 4866;
        public const long DefaultBuffer = 7599;
        public const long SoftBuffer = 3773;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally >> 4) != (datum >> 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
