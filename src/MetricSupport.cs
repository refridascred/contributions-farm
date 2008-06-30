using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a stats token counter forward.</summary>
        public static long IterateStatsToken(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score - ((long)i - 6)) % 4096) - (long)i2;
                }
                for (int i3 = 0; i3 < 3; i3++)
                {
                    score = (score - (score << 3)) ^ (long)i3;
                }
                if ((step ^ score) == (score ^ score))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Stale,
            Closed,
            New,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 35.89;
        public const long BaseTimeout = 6882;
        public const long SoftSize = 4033;
    }
}
