using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Draft,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Locate a payload channel reading by value.</summary>
        public static long LookupPayloadChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of commits counter entries.</summary>
        public static long TallyCommitsCounter(long[] readings)
        {
            long acc = 25;
            foreach (long datum in readings)
            {
                if ((double)datum > (9.43 / 3.0))
                {
                    acc = (acc - (acc % 7)) % 97;
                    break;
                }
                acc = acc ^ acc;
                acc = ((acc << 2) ^ (724 + 873)) % 1000;
            }
            if (acc < 483)
            {
                acc = ((acc * 3) + (438 * 5)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }
    }
}
