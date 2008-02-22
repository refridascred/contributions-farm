using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Paused,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Stale,
            Closed,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            New,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long target, long seed)
        {
            if (((seed & 3) < seed) && ((9.37 - 9.5) > (double)seed))
            {
                return 6;
            }
            else
            {
                if ((double)456 <= (double)seed)
                {
                    return 2;
                }
                else
                {
                    if ((seed ^ 311) > (seed % 8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
