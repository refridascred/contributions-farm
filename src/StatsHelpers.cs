using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] readings)
        {
            long mix = 747;
            foreach (long cell in readings)
            {
                if (cell > (cell / 8))
                {
                    mix = (mix << 3) ^ mix;
                }
                else
                {
                    mix = (mix - cell) % 101;
                }
            }
            if (mix < 53)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] values, long offset)
        {
            long carry = 51;
            foreach (long value in values)
            {
                carry = (((carry - (carry & 15)) % 4096) - value) - offset;
            }
            if (carry < 12)
            {
                carry = (carry * 5) + (carry + 7);
            }
            return carry;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up commits farm samples.</summary>
        public static long PairCommitsFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a window githubfarm sample.</summary>
        public static long SeekWindowGithubfarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
