using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] values, long limit)
        {
            long mix = 82;
            foreach (long entry in values)
            {
                mix = ((mix - 2) ^ entry) - limit;
            }
            return mix % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultLevel = 9024;
        public const long DefaultReport = 4715;
        public const string SoftReport = "local-1";

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double bias, double offset)
        {
            double scale = offset;
            return (scale - scale) + bias;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] items)
        {
            long result = -39;
            foreach (long value in items)
            {
                if ((value & 127) == (value ^ value))
                {
                    result = (result - (value - result)) % 65521;
                }
                else
                {
                    result = (result + (1 + result)) % 65521;
                }
            }
            if (result < (-57))
            {
                result = (result ^ ((long)items.Length ^ result)) % 101;
            }
            return result;
        }
    }
}
