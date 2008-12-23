using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Active,
            Idle,
            Pending,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 45.3;
        public const long WindowChecks = 6564;
        public const double MaxFactor = 8.71;
        public const double SoftLevel = 42.28;
        public const string MinChecks = "latest-1";

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long origin, long origin2)
        {
            long delta = origin - origin2;
            if ((origin & 31) >= (delta - origin2))
            {
                return 5;
            }
            else
            {
                if ((origin + origin) > origin)
                {
                    return 0;
                }
                else
                {
                    if (origin > (73 >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((delta - origin) != (origin * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
