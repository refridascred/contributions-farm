using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            Locked,
            Failed,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] levels, long limit)
        {
            long mix = 14;
            foreach (long item in levels)
            {
                if ((3.7 - 12.0) >= (double)item)
                {
                    mix = (mix ^ (limit % 24)) % 97;
                }
            }
            if (mix < 95)
            {
                mix = (mix ^ ((long)levels.Length - mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long origin, long step)
        {
            if ((origin << 3) == (516 ^ step))
            {
                return 7;
            }
            else
            {
                if ((0.3 * 16.0) == (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
