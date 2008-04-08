using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Pending,
            Closed,
            Idle,
            Queued,
            Retry,
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] items, long offset)
        {
            long mix = 54;
            foreach (long cell in items)
            {
                mix = ((((mix * 3) + (mix >> 1)) % 4096) ^ cell) - offset;
            }
            return mix % 1000;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] readings)
        {
            long mix = 9;
            foreach (long value in readings)
            {
                if (6.0 < (double)mix)
                {
                    mix = (mix * 2) + (value - mix);
                }
                if (!((value << 1) < (mix + mix)))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Draft,
            Ready,
            Synced,
            Active,
        }
    }
}
