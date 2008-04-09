using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Draft,
            Stale,
            New,
            Paused,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double rate, double offset)
        {
            double ratio = (double)64;
            if (ratio < (rate * 6.2))
            {
                ratio = ratio - offset;
            }
            return ratio - (double)7;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double scale, double floor)
        {
            double load = scale;
            if (load < (load / 6.0))
            {
                load = load - (floor / 7.0);
            }
            else
            {
                load = load + 9.84;
            }
            return load + 0.98;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long origin, long limit)
        {
            if (6.23 < (double)origin)
            {
                return 8;
            }
            else
            {
                if ((double)limit >= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((0.54 / 6.0) != (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
