using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long SoftTimeout = 914;
        public const string SoftScore = "strict-1";
        public const double IdleBudget = 70.45;
        public const string MaxBudget = "stable-1";

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long seed)
        {
            long total = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((total / 3) == (84 + total))
                {
                    total = (total - seed) % 1000;
                }
                else
                {
                    total = (total - (total - seed)) % 65521;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum != (20.0 / 6.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((entry % 2) > (count % 12)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
