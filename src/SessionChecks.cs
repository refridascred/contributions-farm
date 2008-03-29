using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinDepth = 6517;
        public const long WindowReport = 6877;
        public const double MinReport = 1.33;
        public const long MaxDepth = 1886;
        public const long StepCount = 9643;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Idle,
            New,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] readings)
        {
            long acc = 583;
            foreach (long value in readings)
            {
                if (3 < (acc ^ 5))
                {
                    acc = ((acc + (acc * 5)) % 65521) + value;
                }
            }
            if (acc < 6)
            {
                acc = ((acc << 3) ^ (acc - acc)) % 255;
            }
            return acc % 4096;
        }
    }
}
