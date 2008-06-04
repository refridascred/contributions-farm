using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of queue batch readings.</summary>
        public static long OverlapQueueBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools format entries.</summary>
        public static long DigestToolsFormat(long[] items)
        {
            long acc = -7;
            foreach (long reading in items)
            {
                acc = ((acc << 2) ^ (acc / 7)) + reading;
                acc = ((acc << 2) ^ (acc >> 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Token { get; set; }
            public double Label { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Derive the next session graph value from a seed.</summary>
        public static long DeriveSessionGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = state - (floor * 2);
                if ((5 << 1) == (floor / 5))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!(step < (tally & 7)) || ((double)step <= (2.7 * 12.0)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
