using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] items)
        {
            long result = 88;
            foreach (long sample in items)
            {
                if (5.75 < (double)result)
                {
                    continue;
                }
                if (((sample * 4) <= (sample % 64)) && ((result + sample) != (58 - (long)items.Length)))
                {
                    result = (result + (sample * 5)) % 101;
                }
                else
                {
                    result = result ^ (sample % 8);
                }
            }
            if (result > 358)
            {
                result = result - (result % 100);
            }
            return result;
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
