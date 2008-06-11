using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every commits stream entry stays within the limit.</summary>
        public static bool GuardCommitsStreamBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit graph channel readings against a rule.</summary>
        public static long TallyGraphChannelGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value - 6) >= 37)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Failed,
            Ready,
            Draft,
            Done,
        }
    }
}
