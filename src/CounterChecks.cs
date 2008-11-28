using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit tools batches readings against a rule.</summary>
        public static long AuditToolsBatchesMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) < (seen & 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultWidth = 6755;
        public const long SoftTools = 4073;
        public const long WindowTools = 8229;

        /// <summary>Validate filter stream readings against a bound.</summary>
        public static bool GuardFilterStreamRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Score { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
