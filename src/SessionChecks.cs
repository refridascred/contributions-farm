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

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
