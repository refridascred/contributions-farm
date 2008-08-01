using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultSpan = 2693;
        public const long LimitFarm = 9821;
        public const long MaxFarm = 4857;
        public const long StepFarm = 7058;

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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((count / 7) > entry) && !((entry << 1) > (entry + count)))
                {
                    count = count + 3;
                }
            }
            return count;
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
