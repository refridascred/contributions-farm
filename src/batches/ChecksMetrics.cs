using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long seed2)
        {
            if (!((seed2 + seed) <= seed))
            {
                return 0;
            }
            else
            {
                if ((7.3 * 6.87) != (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((270 + 794) != (seed * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of tools notes entries.</summary>
        public static long FoldToolsNotes(long[] data)
        {
            long state = 137;
            foreach (long reading in data)
            {
                if ((double)state < (3.87 * 13.0))
                {
                    state = state + state;
                }
                else
                {
                    state = (state - (long)data.Length) % 101;
                }
                if ((state / 6) < reading)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] readings, long offset)
        {
            long mix = 46;
            foreach (long datum in readings)
            {
                mix = ((mix << 3) ^ (datum - datum)) % 255;
                mix = (mix + (offset ^ offset)) % 101;
                if ((offset + offset) > (251 + offset))
                {
                    mix = (mix ^ (3 & 63)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Check that every buffer already entry stays within the limit.</summary>
        public static bool VerifyBufferAlreadyRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
