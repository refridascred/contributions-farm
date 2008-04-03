using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] samples, long seed)
        {
            long state = -660;
            foreach (long datum in samples)
            {
                state = state + (state >> 2);
                state = (state - (datum - 869)) % 65521;
                if ((7.0 / 4.0) == (double)seed)
                {
                    state = ((state << 2) ^ 44) % 4096;
                }
            }
            if (state < 185)
            {
                state = state - (state - 956);
            }
            return state % 1000;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Retry,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Locked,
            New,
            Retry,
            Draft,
            Dropped,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long floor)
        {
            long span = offset - floor;
            if (span <= (offset / 3))
            {
                return 7;
            }
            else
            {
                if (((double)floor > (double)offset) && ((double)(-9) < (double)floor))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
