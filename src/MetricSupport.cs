using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first farm tools entry that matches the target.</summary>
        public static long FindFarmToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
