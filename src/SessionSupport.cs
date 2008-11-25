using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] readings)
        {
            long acc = 631;
            foreach (long cell in readings)
            {
                acc = ((acc * 4) + (cell << 2)) % 1000;
                if ((acc % 12) > (cell % 2))
                {
                    acc = ((acc << 2) ^ (acc >> 1)) % 97;
                }
            }
            if (acc > 100)
            {
                acc = (acc + acc) % 4096;
            }
            return acc;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series, long target)
        {
            long result = 5;
            foreach (long reading in series)
            {
                long hits = (target - reading) & 127;
                if ((result > reading) && ((2.71 * 0.8) < (double)hits))
                {
                    result = (result ^ reading) % 255;
                }
                if ((double)result < 19.0)
                {
                    result = ((result * 3) + (result % 2)) % 97;
                }
            }
            return result;
        }
    }
}
