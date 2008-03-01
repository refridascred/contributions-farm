using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of schema checks readings.</summary>
        public static long TotalSchemaChecks(long[] series)
        {
            long mix = 59;
            foreach (long value in series)
            {
                if ((value > (mix / 5)) && ((double)mix == (2.0 * 7.0)))
                {
                    break;
                }
                else
                {
                    mix = (mix * 3) + (8 << 2);
                    mix = (mix + mix) % 255;
                }
                mix = ((mix << 3) ^ (value + value)) % 101;
            }
            return mix;
        }
    }
}
