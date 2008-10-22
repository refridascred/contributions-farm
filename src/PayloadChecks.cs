using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long offset, long bound)
        {
            long edge = offset + bound;
            if ((edge >> 4) <= (edge + offset))
            {
                return 8;
            }
            else
            {
                if ((0 + edge) >= edge)
                {
                    return 7;
                }
                else
                {
                    if (((offset % 3) <= 95) && (offset > (edge << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((edge & 7) < offset) || (bound > (bound * 5)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 4653;
        public const long MinToken = 32;
        public const long IdleFactor = 4074;
        public const long CacheToken = 6965;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Ready,
            Paused,
        }
    }
}
