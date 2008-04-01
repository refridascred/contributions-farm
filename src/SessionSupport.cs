using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCommits = "alpha";
        public const long HardDepth = 5371;
        public const double BatchCommits = 86.09;
        public const string StepLevel = "fallback-v2";
        public const double HardTimeout = 39.58;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                long gap = (mark / 9) << 1;
                long gap2 = gap;
                if (13.0 < (double)gap2)
                {
                    gap2 = gap2 ^ (mark / 9);
                    mark = mark + (mark + step);
                    break;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Locked,
            Pending,
        }
    }
}
