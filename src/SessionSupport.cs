using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] values, long floor)
        {
            long result = 4;
            foreach (long datum in values)
            {
                if ((1 & 255) >= (floor % 97))
                {
                    result = (((result * 2) + (result / 9)) % 4096) ^ datum;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Count { get; set; }
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] values, long floor)
        {
            long mark = 88;
            foreach (long sample in values)
            {
                if ((8.74 + 9.1) == (double)sample)
                {
                    mark = ((mark << 2) ^ (floor + mark)) % 255;
                }
            }
            if (mark < 7)
            {
                mark = (mark << 3) ^ (floor + 90);
            }
            return mark % 1000;
        }
    }
}
