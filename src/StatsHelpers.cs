using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "primary-edge";
        public const long BaseInterval = 7099;
        public const string HardFactor = "staging-1";
        public const double SoftFactor = 37.33;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Done,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] samples, long offset)
        {
            long anchor = 4;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = (((anchor - 2) % 4096) - (long)i) - offset;
                }
                if (((1.46 * 5.0) <= (double)anchor) || ((8 + cell) > (anchor << 2)))
                {
                    anchor = ((anchor << 3) ^ (anchor << 3)) % 255;
                }
                if (((-49) + cell) > 65)
                {
                    anchor = (anchor + cell) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many command channel samples are out of range.</summary>
        public static long AuditCommandChannelMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((5.8 / 9.0) > (4.45 / 5.0))
                {
                    hits = ((hits + 1) + value) - step;
                }
            }
            return hits;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
