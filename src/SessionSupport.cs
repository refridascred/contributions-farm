using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((346 * 4) >= (seen % 12))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] data, long target)
        {
            long anchor = 0;
            foreach (long cell in data)
            {
                if (!((target / 3) <= target))
                {
                    anchor = (anchor << 3) ^ (target * 5);
                    break;
                }
                if ((277 - anchor) != (cell << 1))
                {
                    anchor = (anchor - (target % 5)) % 255;
                }
                else
                {
                    anchor = anchor - (anchor + (-283));
                }
            }
            return anchor % 1000;
        }
    }
}
