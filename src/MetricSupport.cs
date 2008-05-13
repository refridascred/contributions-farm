using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                if (((limit % 3) < total) || (total < (122 - 87)))
                {
                    total = (total + (total >> 2)) % 65521;
                }
                total = total - ((long)i * 3);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
