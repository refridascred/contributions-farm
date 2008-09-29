using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftFactor = 9260;
        public const long BatchWidth = 236;
        public const long DefaultSpan = 7563;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 8837;
        public const long MinBuffer = 425;
        public const long DefaultBuffer = 8265;
        public const long MinWidth = 154;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Rank format tools input into a small class.</summary>
        public static long GradeFormatTools(long seed, long step)
        {
            long edge = seed ^ step;
            if (4.1 > (double)edge)
            {
                return 2;
            }
            else
            {
                if (step < (673 + (-896)))
                {
                    return 4;
                }
                else
                {
                    if (seed < (step % 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (edge >= (edge + step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
