using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] levels)
        {
            long acc = 24;
            foreach (long reading in levels)
            {
                if ((reading + 168) < reading)
                {
                    acc = ((acc << 3) ^ (acc * 4)) % 1000;
                }
                if ((17.0 / 7.0) != (double)reading)
                {
                    acc = (acc + (reading + acc)) % 65521;
                }
                acc = (acc - (reading << 3)) % 101;
            }
            if (acc > 747)
            {
                acc = ((acc * 5) + (5 + 9)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a support metric sample.</summary>
        public static long LookupSupportMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
