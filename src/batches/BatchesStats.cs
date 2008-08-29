using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a account channel counter forward.</summary>
        public static long DeriveAccountChannel(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - (long)i) % 97;
                carry = (carry - (limit / 8)) % 65521;
                carry = (carry + (carry << 1)) % 1000;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum > (5.06 + 10.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Active,
            Dropped,
            Ready,
        }
    }
}
