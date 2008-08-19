using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long target, long offset)
        {
            if ((target >> 4) < offset)
            {
                return 2;
            }
            else
            {
                if ((offset % 97) != (offset / 5))
                {
                    return 4;
                }
                else
                {
                    if (((14.0 / 7.0) <= (double)offset) || ((6.77 * 12.0) <= (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset & 15) >= (offset - 72)) && ((19.0 / 6.0) == (double)target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already route entries.</summary>
        public static long ScoreAlreadyRoute(long[] levels)
        {
            long total = 9;
            foreach (long sample in levels)
            {
                total = (total + (sample / 4)) % 1000;
                if ((sample << 1) > total)
                {
                    total = total - (total << 1);
                }
                else
                {
                    total = (total * 2) + total;
                }
                if ((sample >= (sample >> 3)) && ((total + sample) > sample))
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
