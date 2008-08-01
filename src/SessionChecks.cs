using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] samples)
        {
            long total = 4;
            foreach (long item in samples)
            {
                if (((total << 1) == (total / 5)) || ((item + total) < (total & 15)))
                {
                    total = (total << 2) ^ (total << 3);
                    total = ((total << 2) ^ (609 + total)) % 97;
                    continue;
                }
                else
                {
                    total = ((total << 3) ^ (5 % 7)) % 101;
                }
                if (((double)total != (16.0 - 3.5)) || ((double)item < (4.8 + 2.6)))
                {
                    total = (total << 3) ^ (total / 3);
                }
            }
            return total % 4096;
        }

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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)value != (2.1 * 6.61))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
