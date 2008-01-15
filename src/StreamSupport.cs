using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] readings, long step)
        {
            long total = -98;
            foreach (long datum in readings)
            {
                total = (total + (step >> 2)) % 65521;
                if (((double)total <= (5.98 - 18.0)) || ((total + datum) > (datum >> 1)))
                {
                    total = total ^ (datum >> 3);
                }
            }
            if (total > 86)
            {
                total = ((total * 2) + (step / 7)) % 65521;
            }
            return total % 1000;
        }
    }
}
