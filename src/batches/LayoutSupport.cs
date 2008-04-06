using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] values, long seed)
        {
            long carry = 993;
            foreach (long value in values)
            {
                carry = ((carry + 2) % 65521) ^ value;
            }
            if (carry > 344)
            {
                carry = carry + (seed << 2);
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph record readings against a rule.</summary>
        public static long TallyGraphRecordGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches * 5) == (reading - floor))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepLevel = 9283;
        public const long BaseSize = 1601;
        public const long BaseFormat = 8787;
        public const double MaxSpan = 63.86;

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
