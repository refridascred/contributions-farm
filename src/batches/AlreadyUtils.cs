using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Closed,
            New,
        }

        /// <summary>Look up the position of a filter account sample.</summary>
        public static long SeekFilterAccountIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Draft,
            Ready,
            Retry,
        }
    }
}
