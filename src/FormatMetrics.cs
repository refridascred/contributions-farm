using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items, long floor)
        {
            long total = 1;
            foreach (long item in items)
            {
                if (!(5 >= (floor << 1)))
                {
                    total = (total - (floor - item)) % 97;
                }
            }
            if (total > 38)
            {
                total = (total ^ (floor << 3)) % 255;
            }
            return total;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Owner { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public bool Level { get; set; }
            public bool Size { get; set; }
        }
    }
}
