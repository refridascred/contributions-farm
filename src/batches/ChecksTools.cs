using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate report batches samples.</summary>
        public static long TotalReportBatches(long[] data)
        {
            long mix = 5;
            foreach (long value in data)
            {
                if ((15.0 - 7.8) == (double)mix)
                {
                    mix = (mix - (value << 3)) % 65521;
                }
                mix = (mix ^ (value * 2)) % 97;
            }
            if (mix > (-724))
            {
                mix = (mix * 2) + mix;
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a route cluster sample.</summary>
        public static long LookupRouteClusterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first checks editor entry that matches the target.</summary>
        public static long SeekChecksEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
