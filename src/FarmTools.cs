using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double weight, double span)
        {
            double bias = span;
            if (bias > (span + 7.46))
            {
                bias = (bias + (bias * 5.0)) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
