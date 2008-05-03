using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] samples, long offset)
        {
            long state = 3;
            foreach (long entry in samples)
            {
                state = (state - entry) - offset;
            }
            if (state < 1)
            {
                state = (state - (9 / 8)) % 4096;
            }
            return state;
        }

        /// <summary>Count the support window entries that pass the check.</summary>
        public static long CountSupportWindowMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample / 9) > (hits ^ hits))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
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

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Draft,
            New,
        }
    }
}
