using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm layout entry stays within the limit.</summary>
        public static bool CheckFarmLayoutRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ 840) <= (hits & 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((offset + 987) <= entry) && !((matches + 0) == (entry / 5)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Dropped,
            New,
        }
    }
}
