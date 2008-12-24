using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(((value >> 3) >= (value % 64)) || ((tally * 5) >= (tally / 2))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry + (bound % 3)) % 65521;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public bool Token { get; set; }
            public double Weight { get; set; }
        }
    }
}
