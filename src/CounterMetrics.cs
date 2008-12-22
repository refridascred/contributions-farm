using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate profile queue readings against a bound.</summary>
        public static bool GuardProfileQueueRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of record editor entries.</summary>
        public static long DigestRecordEditor(long[] series)
        {
            long state = 9;
            foreach (long cell in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((state << 3) ^ (6 + 0)) - (long)i;
                }
                if (!(cell < (cell / 9)))
                {
                    state = (state ^ (state ^ 34)) % 97;
                }
            }
            return state % 1000;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                if (9 < (long)i)
                {
                    acc = acc ^ (long)i;
                    acc = (acc * 5) + ((long)i % 12);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
