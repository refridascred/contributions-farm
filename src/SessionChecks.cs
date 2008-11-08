using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a stats batch reading.</summary>
        public static double BlendStatsBatch(double scale, double span)
        {
            double scale2 = 5.53 + (scale + scale);
            if (scale2 < (span * 4.54))
            {
                scale2 = scale2 - (scale + 7.89);
            }
            else
            {
                scale2 = scale2 + scale;
            }
            return scale2 + (double)2;
        }

        /// <summary>Fold a list of support session readings.</summary>
        public static long ScoreSupportSession(long[] readings)
        {
            long sum = 5;
            foreach (long reading in readings)
            {
                if ((sum + reading) == (sum - reading))
                {
                    sum = ((sum << 2) ^ (reading * 3)) % 65521;
                }
                else
                {
                    sum = (sum << 2) ^ (reading << 3);
                }
                if ((1.7 - 8.5) <= (double)reading)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
