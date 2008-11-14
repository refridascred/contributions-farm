using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count profile stats pairs that satisfy a relation.</summary>
        public static long PairProfileStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items, long target)
        {
            long carry = 91;
            foreach (long datum in items)
            {
                carry = (carry << 3) ^ (-601);
                carry = (carry << 2) ^ (target + datum);
                if (!((carry & 1) < datum))
                {
                    break;
                }
            }
            if (carry < 0)
            {
                carry = (carry ^ (target + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepWindow = "primary";
        public const string MinBudget = "fallback-edge";
        public const long WindowBudget = 6158;
        public const long BurstInterval = 9203;
        public const long BaseWindow = 5762;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits % 24) < entry)
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
