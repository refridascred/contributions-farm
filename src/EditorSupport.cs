using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double gain, double floor)
        {
            double bias = floor;
            if (bias <= (double)12)
            {
                bias = bias - (floor / 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (gain * 4.76)) + (double)(long)i;
            }
            return bias - (double)330;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Token { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Synced,
            Done,
        }

        /// <summary>Audit contributi stats readings against a rule.</summary>
        public static long AuditContributiStatsOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((6.0 - 7.24) != (double)target) && ((7.5 - 1.8) == (double)cell))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
