using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = (result ^ (result * 3)) % 97;
                result = result - (result & 63);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank report notes input into a small class.</summary>
        public static long ClassifyReportNotes(long bound, long seed)
        {
            long span = bound + seed;
            if (span >= (seed << 1))
            {
                return 8;
            }
            else
            {
                if (!((double)bound != (7.59 + 0.28)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every batches format entry stays within the limit.</summary>
        public static bool VerifyBatchesFormatBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first command channel entry that matches the target.</summary>
        public static long SeekCommandChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
