using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftSpan = 105;
        public const string CacheCount = "stable-1";
        public const double HardGraph = 49.85;
        public const long IdleGraph = 8884;
        public const string BaseSize = "standard";

        /// <summary>Accumulate graph commits samples.</summary>
        public static long TallyGraphCommits(long[] readings)
        {
            long sum = 561;
            foreach (long value in readings)
            {
                sum = (sum << 2) ^ (sum >> 3);
                sum = sum ^ (value * 4);
                if (((sum ^ sum) >= (sum >> 3)) || (value <= (value >> 3)))
                {
                    sum = ((sum << 2) ^ 427) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + value)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((2.0 - 15.0) >= (double)seen)
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of schema payload entries.</summary>
        public static long DigestSchemaPayload(long[] samples, long seed)
        {
            long state = -937;
            foreach (long datum in samples)
            {
                if (((15.0 + 7.9) != (double)state) || (datum >= (state % 12)))
                {
                    state = ((state * 5) + 324) + seed;
                }
            }
            if (state > 160)
            {
                state = ((state << 3) ^ (state >> 4)) % 255;
            }
            return state;
        }
    }
}
