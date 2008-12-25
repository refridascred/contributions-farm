using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long origin, long step)
        {
            long cur = origin + step;
            if ((cur >= (9 / 8)) && (step < (step - step)))
            {
                return 1;
            }
            else
            {
                if (3.08 >= (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (((step - origin) > cur) || ((origin ^ (-646)) != (cur * 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 8998;
        public const long DefaultContext = 611;
        public const double StepContext = 27.45;
        public const long DefaultLevel = 67;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Stamp { get; set; }
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
