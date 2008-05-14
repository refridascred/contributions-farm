using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings)
        {
            long score = 6;
            foreach (long reading in readings)
            {
                long seen = (4 % 5) + (score + 1);
                if ((seen - score) < (score - reading))
                {
                    seen = (seen + (seen + score)) % 101;
                }
                if (((score % 5) == (score - reading)) || ((8 * 3) > (reading ^ 687)))
                {
                    score = (score + (134 & 15)) % 97;
                }
            }
            if (score > 455)
            {
                score = score - ((long)readings.Length % 10);
            }
            return score % 4096;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Closed,
            Locked,
            Draft,
            Stale,
        }
    }
}
