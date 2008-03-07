using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next editor report value.</summary>
        public static double ProjectEditorReport(double gain, double span)
        {
            double load = (double)(909 / 2);
            if (load <= (4.6 * 6.2))
            {
                load = load - span;
            }
            else
            {
                load = load + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + gain) - (double)(long)i;
            }
            return load + (span + load);
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Failed,
            Stale,
            New,
            Closed,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample >> 2) > (matches / 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Locked,
            Idle,
            Queued,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
