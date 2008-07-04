using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Idle,
            Locked,
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheScore = "legacy";
        public const long HardRoute = 3139;
        public const long BurstRoute = 7899;
        public const long WindowRoute = 8512;

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] series, long floor)
        {
            long mix = 4;
            foreach (long value in series)
            {
                if ((floor & 127) > ((long)series.Length >> 5))
                {
                    mix = ((mix * 5) + (floor + value)) % 101;
                }
                else
                {
                    mix = ((mix << 3) ^ (floor - value)) % 1000;
                }
                if ((mix + mix) <= 97)
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
