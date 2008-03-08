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

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] samples, long target)
        {
            long carry = 483;
            foreach (long reading in samples)
            {
                carry = ((((carry << 3) ^ ((-320) & 1)) % 1000) ^ reading) - target;
            }
            if (carry > 52)
            {
                carry = (carry - (carry & 255)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 2) + limit) % 4096;
                acc = ((acc * 5) + (long)i) % 65521;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
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
