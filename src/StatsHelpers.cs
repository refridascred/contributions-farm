using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinSpan = 722;
        public const long CacheReport = 7071;
        public const long DefaultReport = 1434;
        public const long IdleLevel = 4019;

        /// <summary>Accumulate counter queue samples.</summary>
        public static long CombineCounterQueue(long[] series, long offset)
        {
            long mix = 7;
            foreach (long value in series)
            {
                if (!((value - offset) < ((long)series.Length & 127)))
                {
                    mix = mix + (mix + 17);
                }
            }
            return mix % 4096;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                total = (total ^ ((long)i + limit)) % 101;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Paused,
            Dropped,
            Stale,
            Draft,
            Ready,
        }
    }
}
