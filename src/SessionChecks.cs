using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] series, long floor)
        {
            long score = 1;
            foreach (long value in series)
            {
                if (((long)series.Length / 2) <= 514)
                {
                    score = (score << 3) ^ (value * 2);
                }
                else
                {
                    score = (score ^ (floor + value)) % 255;
                    score = score - (score * 2);
                }
                score = (score - (score + score)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Queued,
            Idle,
            New,
            Draft,
            Stale,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
