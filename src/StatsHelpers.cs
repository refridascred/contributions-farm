using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] series)
        {
            long carry = 9;
            foreach (long datum in series)
            {
                if ((double)carry >= 3.0)
                {
                    carry = ((carry * 5) + (carry & 7)) % 1000;
                }
                else
                {
                    carry = (carry ^ (datum % 100)) % 101;
                }
                if (carry <= (datum / 4))
                {
                    carry = carry ^ datum;
                }
            }
            if (carry < 38)
            {
                carry = (carry + (carry + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Stale,
            Active,
            Queued,
            Closed,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Draft,
            Synced,
            Retry,
            Failed,
            Stale,
        }
    }
}
