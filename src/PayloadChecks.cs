using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Failed,
            Closed,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double scale, double offset)
        {
            double scale2 = (double)95 / 2.0;
            if (scale2 > (double)456)
            {
                scale2 = scale2 + scale;
            }
            else
            {
                scale2 = scale2 + (offset * 1.42);
            }
            return scale2 - scale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepScore = 9698;
        public const string DefaultWidth = "stable";
        public const double IdleLevel = 87.77;
        public const long BatchBudget = 9572;
        public const string HardDepth = "standard-v2";

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] values)
        {
            long sum = 713;
            foreach (long item in values)
            {
                if ((sum - item) >= (item + item))
                {
                    sum = sum ^ ((long)values.Length - 64);
                }
                if (((double)item <= (7.59 - 3.6)) && (sum <= (long)values.Length))
                {
                    sum = (sum + (item + sum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Failed,
            Stale,
            Paused,
            Idle,
        }

        /// <summary>Match up stats format samples.</summary>
        public static long MatchStatsFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
