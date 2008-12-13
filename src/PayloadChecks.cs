using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long origin, long seed)
        {
            long delta = origin + seed;
            if (!((origin + seed) < seed))
            {
                return 5;
            }
            else
            {
                if ((delta < (origin + 769)) || ((delta * 2) < (delta / 3)))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed == (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if (delta <= seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
