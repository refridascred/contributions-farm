using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double bias, double bias2)
        {
            double drift = bias2;
            if (drift >= bias)
            {
                drift = drift - (8.3 + bias);
            }
            return drift + bias2;
        }

        /// <summary>Measure how many notes account samples are out of range.</summary>
        public static long CountNotesAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits % 8) < (item + item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Queued,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] items)
        {
            long score = 65;
            foreach (long item in items)
            {
                if (((double)item >= (5.91 * 4.3)) || ((double)score > 5.0))
                {
                    score = score + (item + item);
                }
            }
            return score;
        }
    }
}
