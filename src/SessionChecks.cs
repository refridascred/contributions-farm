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

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
