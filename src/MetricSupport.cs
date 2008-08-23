using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] series, long origin)
        {
            long total = -3;
            foreach (long value in series)
            {
                if (origin >= (value - value))
                {
                    total = (total ^ total) % 1000;
                }
            }
            if (total < 71)
            {
                total = ((total << 2) ^ origin) % 97;
            }
            return total % 65521;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a layout filter counter forward.</summary>
        public static long StepLayoutFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
