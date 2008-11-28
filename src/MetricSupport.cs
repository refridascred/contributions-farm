using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] levels)
        {
            long mix = 57;
            foreach (long datum in levels)
            {
                mix = ((mix * 4) + mix) + datum;
                mix = ((mix << 2) ^ mix) % 1000;
            }
            if (mix < 895)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
