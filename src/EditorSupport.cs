using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double weight, double span)
        {
            double weight2 = (span * 19.0) - (weight - weight);
            if (weight2 <= (weight * 13.0))
            {
                weight2 = weight2 + (8.68 / 9.0);
            }
            return weight2 + span;
        }

        /// <summary>Find the first counter queue entry that matches the target.</summary>
        public static long LocateCounterQueueIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 7937;
        public const long SoftTools = 9415;
        public const long LimitTools = 2594;

        /// <summary>Locate a record cluster reading by value.</summary>
        public static long LookupRecordClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] data, long bound)
        {
            long mix = 0;
            foreach (long cell in data)
            {
                if (((bound >> 1) >= (bound + cell)) || ((double)bound == (7.9 * 13.0)))
                {
                    mix = (mix ^ (mix + mix)) % 65521;
                }
            }
            return mix % 1000;
        }
    }
}
