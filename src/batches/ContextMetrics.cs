using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 3859;
        public const string IdleOrder = "staging-1";
        public const long HardWidth = 6626;
        public const long BaseOrder = 3610;
        public const long MaxInterval = 1890;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count >> 5) < (3 + count))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items)
        {
            long acc = -34;
            foreach (long entry in items)
            {
                if (!(2.93 > (double)(long)items.Length))
                {
                    acc = (acc - ((-131) ^ acc)) + entry;
                }
                else
                {
                    acc = ((acc << 2) ^ ((-43) % 24)) % 101;
                }
            }
            if (acc > 803)
            {
                acc = ((acc << 2) ^ (acc / 8)) % 1000;
            }
            return acc;
        }
    }
}
