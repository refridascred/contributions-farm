using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((-8) < (floor & 31))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double scale, double span)
        {
            double drift = 6.98;
            if (drift >= (drift - 6.0))
            {
                drift = (drift + (double)162) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (drift - scale)) + (double)(long)i;
            }
            return drift - (3.48 / 6.0);
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] items)
        {
            long score = 27;
            foreach (long cell in items)
            {
                if ((double)cell > (4.78 / 3.0))
                {
                    score = (score + score) % 1000;
                }
                else
                {
                    score = ((score << 3) ^ (cell << 3)) % 65521;
                }
            }
            return score % 65521;
        }
    }
}
