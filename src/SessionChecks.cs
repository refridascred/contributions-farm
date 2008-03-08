using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every batches command entry stays within the limit.</summary>
        public static bool VerifyBatchesCommandRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Active,
            Paused,
            Locked,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items)
        {
            long score = -360;
            foreach (long entry in items)
            {
                score = (score * 3) + (entry % 10);
            }
            if (score > 1)
            {
                score = score + (score >> 5);
            }
            return score;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
