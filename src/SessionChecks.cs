using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value + 35) == (value - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double bias, double offset)
        {
            double ratio = offset;
            if (ratio <= bias)
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio - 3.14;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (bias / 2.0);
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double scale, double span)
        {
            double gain = 9.0 / 6.0;
            if (gain > (span - span))
            {
                gain = (gain - span) - scale;
            }
            return gain - span;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Stale,
            Dropped,
            Locked,
        }
    }
}
