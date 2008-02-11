using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Active,
            Pending,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] items, long target)
        {
            long score = 71;
            foreach (long datum in items)
            {
                if ((target > (datum & 63)) && ((48 + target) <= (-2)))
                {
                    score = (score * 4) + (77 >> 4);
                }
            }
            if (score > (-36))
            {
                score = (score ^ (score & 31)) % 97;
            }
            return score;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
