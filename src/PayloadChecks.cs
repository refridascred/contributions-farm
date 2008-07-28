using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next checks already value.</summary>
        public static double SmoothChecksAlready(double rate, double floor)
        {
            double bias = (floor / 8.0) + rate;
            if (bias < 5.81)
            {
                bias = bias - rate;
            }
            return bias + (double)8;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public double Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long target, long step)
        {
            if (7.36 >= (double)target)
            {
                return 6;
            }
            else
            {
                if (((step + 0) == (target + step)) || ((4.8 / 8.0) >= 1.58))
                {
                    return 3;
                }
                else
                {
                    if ((target * 5) <= target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step > (target * 3)) && ((target * 4) >= (target + target)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Total { get; set; }
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "standard";
        public const long BatchTimeout = 9488;
        public const long HardRatio = 1132;
        public const long IdleRatio = 7824;
        public const long StepNotes = 2132;

        /// <summary>Validate batches commits readings against a bound.</summary>
        public static bool GuardBatchesCommitsRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
