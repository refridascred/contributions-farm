using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Failed,
            Retry,
            Done,
            Stale,
            Closed,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Stale,
            Idle,
            Failed,
            Draft,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of batch tools readings.</summary>
        public static long TallyBatchTools(long[] series, long seed)
        {
            long mix = 2;
            foreach (long cell in series)
            {
                mix = (((mix * 5) + ((long)series.Length + cell)) % 101) - seed;
            }
            return mix;
        }
    }
}
