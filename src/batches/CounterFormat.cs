using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next tools context value from a seed.</summary>
        public static long RollToolsContext(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                if (152 >= offset)
                {
                    sum = ((sum << 2) ^ (sum << 1)) % 97;
                }
                if ((sum % 16) > (229 >> 2))
                {
                    long diff = 6;
                    sum = sum ^ diff;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((bound ^ tally) < item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit buffer window readings against a rule.</summary>
        public static long MeasureBufferWindowHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (floor > (tally - tally))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
