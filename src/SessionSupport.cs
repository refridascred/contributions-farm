using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell >= (count ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Failed,
            Locked,
            Queued,
            Draft,
        }
    }
}
