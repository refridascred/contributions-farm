using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Score { get; set; }
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "local-edge";
        public const long HardAccount = 1389;
        public const long BatchFactor = 5781;

        /// <summary>Validate format commits readings against a bound.</summary>
        public static bool CheckFormatCommitsBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a already stats reading.</summary>
        public static double BlendAlreadyStats(double rate, double bias)
        {
            double load = (rate + rate) - rate;
            if (load <= (double)39)
            {
                load = (load - rate) + bias;
            }
            return load - 8.2;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (5.22 > (double)reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
