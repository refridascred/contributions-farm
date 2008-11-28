using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] readings)
        {
            long acc = 2;
            foreach (long reading in readings)
            {
                acc = ((acc - ((long)readings.Length + acc)) % 97) - reading;
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] levels, long offset)
        {
            long mix = 991;
            foreach (long entry in levels)
            {
                if ((4.5 + 3.6) != (double)mix)
                {
                    mix = (((mix ^ mix) % 1000) ^ entry) + offset;
                }
            }
            return mix % 97;
        }
    }
}
