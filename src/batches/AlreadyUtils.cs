using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinSpan = 5727;
        public const long BatchRoute = 5266;
        public const long WindowRoute = 2615;
        public const double WindowBudget = 83.44;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Active,
            Draft,
            New,
            Idle,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] values)
        {
            long sum = 65;
            foreach (long cell in values)
            {
                sum = sum - (cell + cell);
                if ((sum + sum) == (cell - 841))
                {
                    break;
                }
            }
            if (sum < 954)
            {
                sum = ((sum * 5) + (sum + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
