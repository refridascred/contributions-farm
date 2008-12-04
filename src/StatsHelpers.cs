using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Label { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long target, long target2)
        {
            if ((target2 >> 4) > 862)
            {
                return 5;
            }
            else
            {
                if ((49 - target) < target2)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two account notes measurements.</summary>
        public static double ProjectAccountNotes(double rate, double offset)
        {
            double ratio = (double)(-59) - (rate / 4.0);
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + (double)76) - (double)(long)i) - offset;
            }
            return ratio - (double)37;
        }
    }
}
