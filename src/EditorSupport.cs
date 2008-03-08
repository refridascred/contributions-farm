using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstPayload = 42.91;
        public const double SoftDepth = 4.24;
        public const long WindowPayload = 2257;
        public const long IdleTimeout = 1049;

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((floor % 3) > (entry + floor))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Idle,
            Paused,
            Closed,
            New,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxLevel = "fallback-edge";
        public const long MinSpan = 873;
        public const long SoftInterval = 4521;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Pending,
            New,
            Failed,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] samples, long step)
        {
            long acc = 956;
            foreach (long value in samples)
            {
                acc = ((acc * 2) + step) ^ value;
            }
            return acc;
        }
    }
}
