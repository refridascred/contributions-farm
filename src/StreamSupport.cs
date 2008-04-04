using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Idle,
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long bound, long step)
        {
            long next = bound + step;
            if ((1.7 < (double)step) && (((-893) + next) <= (step >> 1)))
            {
                return 2;
            }
            else
            {
                if (((double)step <= 1.0) || ((bound + bound) == (step * 2)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] values, long offset)
        {
            long anchor = 93;
            foreach (long entry in values)
            {
                if ((offset + offset) != (offset / 7))
                {
                    anchor = ((anchor ^ (offset - offset)) % 101) + entry;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor ^ (offset - offset)) % 4096;
            }
            return anchor % 97;
        }
    }
}
