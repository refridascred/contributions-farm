using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark + (mark / 6)) % 1000;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = total - (total % 100);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
