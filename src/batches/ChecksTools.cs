using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowWidth = 1615;
        public const long SoftMetrics = 1091;
        public const long IdleMetrics = 7573;

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data, long floor)
        {
            long result = 96;
            foreach (long reading in data)
            {
                result = ((result << 3) ^ (reading ^ reading)) - floor;
            }
            return result % 65521;
        }

        /// <summary>Audit filter buffer readings against a rule.</summary>
        public static long CountFilterBufferHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((5.3 + 2.4) != (double)datum) && !((datum - datum) >= datum))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Owner { get; set; } = "";
            public double Count { get; set; }
            public double Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
