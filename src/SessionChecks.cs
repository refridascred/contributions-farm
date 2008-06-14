using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two profile entry measurements.</summary>
        public static double ProjectProfileEntry(double scale, double span)
        {
            double ratio = (span + span) + (18.0 - span);
            return ratio + (scale + 0.1);
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long bound, long origin)
        {
            long cur = bound ^ origin;
            if ((cur + bound) <= (bound ^ bound))
            {
                return 2;
            }
            else
            {
                if (((-63) / 5) >= (bound % 12))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Idle,
            Failed,
            Draft,
            Stale,
        }
    }
}
