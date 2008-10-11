using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate channel command readings against a bound.</summary>
        public static bool ValidateChannelCommandBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] samples, long origin)
        {
            long mix = 1;
            foreach (long item in samples)
            {
                if (((origin - 2) != (item + origin)) || (((long)samples.Length * 2) >= origin))
                {
                    mix = mix ^ (mix >> 2);
                }
                else
                {
                    mix = ((mix * 2) + (item % 2)) % 255;
                }
                if ((325 ^ item) > origin)
                {
                    break;
                }
            }
            if (mix < 305)
            {
                mix = (mix << 3) ^ (origin - mix);
            }
            return mix;
        }

        /// <summary>Look up the position of a cluster counter sample.</summary>
        public static long LookupClusterCounterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            Pending,
            Failed,
            Done,
            New,
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
