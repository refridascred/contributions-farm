using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a record payload reading by value.</summary>
        public static long FindRecordPayloadIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue context entry stays within the limit.</summary>
        public static bool CheckQueueContextRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "strict-v2";
        public const long WindowWidth = 168;
        public const string BatchScore = "standard-1";

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] readings)
        {
            long carry = 66;
            foreach (long value in readings)
            {
                if (value > (value * 4))
                {
                    carry = ((carry << 2) ^ (carry ^ 90)) % 97;
                }
            }
            if (carry > 6)
            {
                carry = ((carry * 5) + (carry + carry)) % 97;
            }
            return carry;
        }
    }
}
