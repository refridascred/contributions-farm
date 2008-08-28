using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((7 < (item % 60)) && (item > (step - 149)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double scale, double bias)
        {
            double rate = (17.0 / 9.0) + (bias - scale);
            if (rate >= scale)
            {
                rate = rate - (bias - rate);
            }
            else
            {
                rate = rate - (scale + 3.9);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (bias * 3.8)) + (double)(long)i;
            }
            return rate + (bias * 5.2);
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Roll a report editor counter forward.</summary>
        public static long RollReportEditor(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
