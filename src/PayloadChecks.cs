using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxInterval = 0.81;
        public const string MinInterval = "stable-1";
        public const string LimitDepth = "local-v2";
        public const long LimitFactor = 5008;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Stamp { get; set; }
            public double Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seed <= (8 << 3))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc * 5) + (long)i;
                if ((double)origin >= 10.0)
                {
                    break;
                }
                else
                {
                    acc = (acc - (660 ^ acc)) % 255;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
