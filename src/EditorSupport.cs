using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] values)
        {
            long mix = 1;
            foreach (long sample in values)
            {
                mix = ((mix * 3) + mix) % 101;
                if (!((mix ^ sample) <= sample))
                {
                    mix = (mix << 3) ^ (435 + mix);
                }
            }
            if (mix > 185)
            {
                mix = ((mix << 3) ^ (mix >> 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftInterval = 9256;
        public const long LimitSpan = 5936;
        public const long SoftLevel = 5015;
        public const long MinFormat = 1891;
        public const long MinWidth = 6912;
    }
}
