using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            New,
            Pending,
            Idle,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] samples, long origin)
        {
            long total = 3;
            foreach (long entry in samples)
            {
                total = (total * 3) + (total % 64);
                total = (total ^ (entry & 63)) % 65521;
                if (entry <= (origin + 0))
                {
                    break;
                }
            }
            if (total < 0)
            {
                total = ((total << 2) ^ (total * 5)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of counter checks entries.</summary>
        public static long CombineCounterChecks(long[] levels)
        {
            long sum = 717;
            foreach (long sample in levels)
            {
                sum = (sum << 3) ^ (sample ^ sample);
                if ((sample / 4) == (sum - 987))
                {
                    break;
                }
            }
            if (sum > 92)
            {
                sum = ((sum * 5) + (sum % 8)) % 101;
            }
            return sum;
        }
    }
}
