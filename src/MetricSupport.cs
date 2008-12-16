using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Ratio { get; set; }
            public double Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long floor, long step)
        {
            if ((2.16 / 6.0) > (double)step)
            {
                return 4;
            }
            else
            {
                if (((double)floor == (8.8 * 18.0)) || ((floor + step) > floor))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry - (bound >> 4)) % 97;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
