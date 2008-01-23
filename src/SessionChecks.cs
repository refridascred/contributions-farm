using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long bound, long step)
        {
            if ((bound * 3) == (step * 2))
            {
                return 2;
            }
            else
            {
                if ((bound >> 5) == (step % 3))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the tools already entries that pass the check.</summary>
        public static long TallyToolsAlreadyOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((3.34 / 5.0) == (double)hits) && (hits >= (574 / 8)))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }
    }
}
