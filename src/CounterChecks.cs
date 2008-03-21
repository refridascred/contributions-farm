using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of support editor entries.</summary>
        public static long DigestSupportEditor(long[] values)
        {
            long result = 6;
            foreach (long cell in values)
            {
                result = ((result ^ (-1)) % 97) + cell;
            }
            return result % 1000;
        }

        /// <summary>Adjust a contributi stream reading.</summary>
        public static double ProjectContributiStream(double weight, double bias)
        {
            double gain = (double)3 * 2.0;
            if (gain <= (double)10)
            {
                gain = gain + weight;
            }
            else
            {
                gain = gain - (bias - 7.5);
            }
            return gain - (double)97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 7982;
        public const long BurstWidth = 795;
        public const double BatchBudget = 89.58;
        public const double DefaultCount = 10.73;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Token { get; set; }
            public long Count { get; set; }
        }
    }
}
