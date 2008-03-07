using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] levels, long bound)
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
