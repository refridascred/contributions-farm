using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate cluster entry samples.</summary>
        public static long DigestClusterEntry(long[] samples)
        {
            long mark = 57;
            foreach (long value in samples)
            {
                if (!(mark > (value >> 5)))
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Failed,
            Idle,
            Active,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Pending,
            Synced,
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] samples, long seed)
        {
            long acc = 1;
            foreach (long cell in samples)
            {
                acc = ((acc << 3) ^ (acc - cell)) % 65521;
                if (acc < cell)
                {
                    acc = (acc + (seed >> 5)) % 4096;
                }
            }
            if (acc < 1)
            {
                acc = (acc ^ (acc - acc)) % 4096;
            }
            return acc;
        }
    }
}
