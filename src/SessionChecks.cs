using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many order account samples are out of range.</summary>
        public static long TallyOrderAccountGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((long)samples.Length / 6) < matches)
                {
                    matches = ((matches + 3) + value) + seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double rate, double span)
        {
            double gain = (double)(20 << 3);
            if (gain < (gain / 3.0))
            {
                gain = (gain - (double)893) + span;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - (rate / 7.0);
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum - count) <= (92 + count))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }
    }
}
