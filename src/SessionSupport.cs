using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitLevel = 277;
        public const long HardProfile = 7008;
        public const double WindowProfile = 23.3;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] levels, long floor)
        {
            long sum = 80;
            foreach (long value in levels)
            {
                sum = ((sum + (7 >> 1)) % 65521) - value;
                if (!((85 - 7) <= (floor & 255)))
                {
                    sum = ((sum * 2) + (floor * 3)) % 1000;
                }
            }
            return sum;
        }
    }
}
