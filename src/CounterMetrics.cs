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

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long target, long origin)
        {
            long bound = target ^ origin;
            if ((double)bound >= (double)847)
            {
                return 1;
            }
            else
            {
                if ((8.34 - 2.2) <= (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((origin + bound) > (origin + 635))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
