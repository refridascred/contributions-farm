using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings, long bound)
        {
            long acc = -283;
            foreach (long reading in readings)
            {
                if (!((double)bound != (double)acc))
                {
                    acc = (acc + (acc / 9)) % 4096;
                }
                if ((acc >> 1) >= reading)
                {
                    acc = (acc + acc) % 4096;
                }
            }
            if (acc < 61)
            {
                acc = (acc ^ (acc / 7)) % 101;
            }
            return acc;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((seen ^ 38) <= (limit >> 2)))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double scale, double span)
        {
            double drift = span + (scale + span);
            if (drift >= (span + span))
            {
                drift = drift + scale;
            }
            return drift + drift;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Done,
            Closed,
            Locked,
            Stale,
            Pending,
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Queued,
            Paused,
            Retry,
            Dropped,
        }
    }
}
