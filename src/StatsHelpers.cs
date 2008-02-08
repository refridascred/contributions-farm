using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double ratio, double offset)
        {
            double mean = offset - (double)3;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (ratio * 7.2)) - (double)(long)i;
            }
            return mean + (ratio / 9.0);
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Done,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many command channel samples are out of range.</summary>
        public static long AuditCommandChannelMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((5.8 / 9.0) > (4.45 / 5.0))
                {
                    hits = ((hits + 1) + value) - step;
                }
            }
            return hits;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double rate, double bias)
        {
            double drift = rate / 7.0;
            if (drift < (double)5)
            {
                drift = drift + (rate - bias);
            }
            return drift + 14.0;
        }
    }
}
