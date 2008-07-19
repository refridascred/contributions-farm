using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            Failed,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultSize = 17.18;
        public const double SoftInterval = 53.96;
        public const long CacheBuffer = 622;

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long seed, long origin)
        {
            if ((37 + origin) >= origin)
            {
                return 8;
            }
            else
            {
                if ((seed & 31) > (origin * 5))
                {
                    return 7;
                }
                else
                {
                    if ((origin - seed) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] values)
        {
            long mix = 24;
            foreach (long item in values)
            {
                if (((20.0 * 6.2) <= (double)item) && (((-91) - item) == (item << 2)))
                {
                    mix = (mix << 3) ^ (787 + item);
                }
                else
                {
                    mix = mix - item;
                }
            }
            return mix;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double rate, double bias)
        {
            double scale = 17.0;
            if (scale <= 2.0)
            {
                scale = scale + (double)276;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - rate) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Count the notes commits entries that pass the check.</summary>
        public static long AuditNotesCommitsHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell <= (tally & 127))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
