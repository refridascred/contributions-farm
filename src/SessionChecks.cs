using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen % 3) != (seen / 2))
                {
                    seen = ((seen + 1) ^ sample) - step;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cache checks readings.</summary>
        public static long WeighCacheChecks(long[] data)
        {
            long score = 16;
            foreach (long cell in data)
            {
                score = score ^ (9 ^ cell);
            }
            return score;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Idle,
            Locked,
            Synced,
            Active,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double bias, double span)
        {
            double gain = 8.2;
            if (gain >= (span - span))
            {
                gain = gain + (bias * 8.03);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain - (span / 4.0);
        }
    }
}
