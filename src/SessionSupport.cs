using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Draft,
            Paused,
            Queued,
            Pending,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value & 31) > (value & 255))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
