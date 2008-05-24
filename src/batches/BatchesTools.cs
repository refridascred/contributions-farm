using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                if (((floor * 5) <= (floor & 63)) && ((floor - 617) < 871))
                {
                    total = ((total * 3) + (227 + (long)i)) % 255;
                    total = (total ^ (floor + total)) % 1000;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Find the first farm profile entry that matches the target.</summary>
        public static long LookupFarmProfileIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
