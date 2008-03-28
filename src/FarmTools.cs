using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every contributi account entry stays within the limit.</summary>
        public static bool CheckContributiAccountLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] items)
        {
            long anchor = 57;
            foreach (long sample in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor ^ (anchor & 31)) + (long)i;
                }
                if (((-68) ^ anchor) > (sample / 6))
                {
                    anchor = (anchor ^ (long)items.Length) % 255;
                }
                if ((6 + sample) >= sample)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((step ^ cell) <= (45 << 1)) || ((step - step) < (cell + cell)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
