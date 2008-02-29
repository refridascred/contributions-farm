using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a checks window counter forward.</summary>
        public static long IterateChecksWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                acc = acc + (target << 1);
                acc = ((acc * 3) + target) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate metric channel samples.</summary>
        public static long ScoreMetricChannel(long[] items, long origin)
        {
            long acc = 9;
            foreach (long reading in items)
            {
                if ((acc - acc) < (reading - reading))
                {
                    acc = (acc + ((-6) ^ origin)) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Stale,
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double gain, double span)
        {
            double ratio = (double)((-77) * 5);
            if (ratio < gain)
            {
                ratio = ratio - (gain - span);
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + ratio;
        }
    }
}
