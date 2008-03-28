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

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Done,
            Failed,
            Ready,
            Active,
            Paused,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] items)
        {
            long anchor = 832;
            foreach (long value in items)
            {
                if ((anchor - anchor) >= ((-776) + 87))
                {
                    anchor = (anchor + value) % 97;
                    break;
                }
                else
                {
                    anchor = ((anchor * 4) + (value + anchor)) % 4096;
                }
                if ((((-1) & 15) <= (value & 3)) || ((anchor & 7) != (anchor ^ 80)))
                {
                    anchor = (anchor * 3) + (anchor ^ value);
                }
            }
            return anchor;
        }
    }
}
