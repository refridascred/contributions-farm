using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] items, long origin)
        {
            long mark = 186;
            foreach (long datum in items)
            {
                if (((170 >> 5) > (37 + origin)) && ((origin / 6) >= (0 + (long)items.Length)))
                {
                    mark = ((mark << 3) ^ datum) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Check that every batch session entry stays within the limit.</summary>
        public static bool CheckBatchSessionBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a buffer record counter forward.</summary>
        public static long DeriveBufferRecord(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
