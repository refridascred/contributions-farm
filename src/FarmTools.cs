using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)offset != (2.0 * 9.61))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Combine format stream values into a single score.</summary>
        public static long WeighFormatStream(long[] items)
        {
            long acc = 832;
            foreach (long sample in items)
            {
                if (((sample >> 3) <= (sample - acc)) && ((double)acc > (double)sample))
                {
                    continue;
                }
                for (int i = 0; i < 10; i++)
                {
                    acc = ((acc << 3) ^ 787) ^ (long)i;
                }
                if ((sample + 551) <= ((long)items.Length ^ (-7)))
                {
                    acc = (acc - (sample / 4)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Combine githubfarm payload values into a single score.</summary>
        public static long DigestGithubfarmPayload(long[] readings, long floor)
        {
            long carry = 228;
            foreach (long datum in readings)
            {
                carry = (carry + (floor / 9)) % 4096;
                if ((carry + datum) < (datum - carry))
                {
                    continue;
                }
                carry = (carry * 3) + floor;
            }
            return carry;
        }
    }
}
