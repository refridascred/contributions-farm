using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                if (origin >= ((long)i - anchor))
                {
                    anchor = (anchor << 3) ^ anchor;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (origin - origin)) % 4096;
                }
                anchor = anchor ^ ((long)i >> 4);
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
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

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
