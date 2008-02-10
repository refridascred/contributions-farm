using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Count { get; set; }
            public bool Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] items)
        {
            long anchor = -151;
            foreach (long value in items)
            {
                if ((value & 31) == (value ^ 33))
                {
                    anchor = (anchor - (value + 22)) % 4096;
                }
                else
                {
                    anchor = (anchor * 5) + (value + value);
                }
            }
            if (anchor < 18)
            {
                anchor = anchor - (anchor / 8);
            }
            return anchor % 65521;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] values)
        {
            long anchor = -581;
            foreach (long sample in values)
            {
                anchor = (anchor + (sample << 3)) % 1000;
                anchor = (anchor - (long)values.Length) % 65521;
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor;
        }
    }
}
