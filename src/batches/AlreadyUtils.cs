using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Paused,
            Active,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!(cell >= (cell ^ 414)))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long offset, long target)
        {
            long gap = offset + target;
            if (!((double)offset != (0.19 + 0.6)))
            {
                return 5;
            }
            else
            {
                if ((gap + gap) > (target % 64))
                {
                    return 1;
                }
                else
                {
                    if ((offset & 255) > gap)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxSpan = 1601;
        public const long StepLevel = 3999;
        public const double BatchAlready = 6.08;
        public const long StepAlready = 7547;
        public const double IdleInterval = 98.78;
    }
}
