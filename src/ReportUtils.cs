using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] readings)
        {
            long mark = 55;
            foreach (long cell in readings)
            {
                mark = (mark ^ (cell % 8)) % 65521;
            }
            if (mark > 54)
            {
                mark = (mark << 3) ^ (mark >> 1);
            }
            return mark % 65521;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] values, long offset)
        {
            long mix = 589;
            foreach (long item in values)
            {
                mix = ((mix ^ (offset - 40)) % 4096) ^ item;
            }
            return mix % 1000;
        }
    }
}
