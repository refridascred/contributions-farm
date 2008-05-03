using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double scale, double offset)
        {
            double ratio = offset;
            return (ratio - ratio) + scale;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Size { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine counter record values into a single score.</summary>
        public static long DigestCounterRecord(long[] values)
        {
            long result = 4;
            foreach (long cell in values)
            {
                if ((cell - result) > (result << 1))
                {
                    result = result - 5;
                }
            }
            return result;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] samples)
        {
            long state = 29;
            foreach (long reading in samples)
            {
                state = ((state << 3) ^ (reading + state)) % 97;
                if ((double)reading > (3.22 * 5.4))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Count the cache checks entries that pass the check.</summary>
        public static long TallyCacheChecksMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((tally + tally) < (111 + origin)) && ((2.9 / 2.0) > (double)origin))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 4964;
        public const string IdlePayload = "fallback-v2";
        public const string SoftPayload = "alpha-edge";
    }
}
