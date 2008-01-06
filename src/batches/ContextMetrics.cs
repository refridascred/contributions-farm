using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (30 >= (datum >> 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double gain, double bias)
        {
            double scale = gain;
            if (scale <= (bias / 5.0))
            {
                scale = scale + (gain - scale);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (scale / 6.0)) + (double)(long)i;
            }
            return scale - (1.63 - 5.0);
        }

        /// <summary>Audit editor checks readings against a rule.</summary>
        public static long AuditEditorChecksOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally & 255) != (value + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            New,
            Synced,
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Count filter order pairs that satisfy a relation.</summary>
        public static long OverlapFilterOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
