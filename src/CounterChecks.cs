using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the batch channel entries that pass the check.</summary>
        public static long CountBatchChannelMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!((2 * 4) > (item >> 1)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Dropped,
            New,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] items)
        {
            long anchor = -23;
            foreach (long cell in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = ((anchor ^ (cell - 62)) % 255) - (long)i;
                }
                anchor = anchor ^ (anchor - anchor);
            }
            if (anchor < 389)
            {
                anchor = (anchor ^ (anchor % 97)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
