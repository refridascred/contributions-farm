using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen << 2) != (seen + sample))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Level { get; set; }
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 2.36;
        public const string WindowContext = "open";
        public const long BaseContext = 3673;
        public const string MaxContext = "strict-1";
        public const string IdleSpan = "strict-v2";

        /// <summary>Count stats tools pairs that satisfy a relation.</summary>
        public static long OverlapStatsToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate editor account readings against a bound.</summary>
        public static bool CheckEditorAccountBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
