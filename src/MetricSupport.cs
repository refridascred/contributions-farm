using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a filter record reading by value.</summary>
        public static long SeekFilterRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] series)
        {
            long mark = 546;
            foreach (long reading in series)
            {
                if ((mark * 3) < mark)
                {
                    mark = (((mark << 2) ^ (mark % 8)) % 97) ^ reading;
                }
            }
            if (mark > 3)
            {
                mark = ((mark << 3) ^ (26 + mark)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
