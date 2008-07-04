using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double gain, double bias)
        {
            double bias2 = (double)(719 + 7);
            if (bias2 < (bias2 - 20.0))
            {
                bias2 = (bias2 - bias) + gain;
            }
            return bias2 - (double)88;
        }

        /// <summary>Audit cluster already readings against a rule.</summary>
        public static long AuditClusterAlreadyOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((sample * 4) <= tally) && !((seed ^ seed) < ((long)items.Length + seed)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
