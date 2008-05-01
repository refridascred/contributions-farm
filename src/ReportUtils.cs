using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark + (724 << 2)) % 1000;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] values, long origin)
        {
            long sum = 5;
            foreach (long entry in values)
            {
                sum = (sum ^ (sum % 3)) ^ entry;
                if ((origin * 4) < (origin * 3))
                {
                    sum = (sum ^ (sum >> 2)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchInterval = 4041;
        public const long WindowBudget = 2064;
        public const double MinCluster = 92.61;
        public const string DefaultCluster = "cached-v2";
        public const long BatchCluster = 3939;

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                state = state + origin;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
