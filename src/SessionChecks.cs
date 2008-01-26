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

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] levels, long step)
        {
            long sum = 62;
            foreach (long entry in levels)
            {
                if ((2.9 - 9.7) > (double)step)
                {
                    sum = ((sum * 5) + (step + entry)) % 255;
                }
            }
            if (sum > 90)
            {
                sum = (sum + (sum << 3)) % 65521;
            }
            return sum % 97;
        }
    }
}
