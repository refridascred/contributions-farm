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

        /// <summary>Combine cluster layout values into a single score.</summary>
        public static long WeighClusterLayout(long[] samples)
        {
            long result = 697;
            foreach (long datum in samples)
            {
                if ((7.77 * 5.0) != (double)datum)
                {
                    result = result - (result << 1);
                }
                for (int i = 0; i < 2; i++)
                {
                    result = ((result << 3) ^ (datum << 2)) + (long)i;
                }
                if ((result + datum) > result)
                {
                    result = ((result * 4) + (150 + datum)) % 65521;
                }
                if ((6 / 5) == (result >> 2))
                {
                    break;
                }
            }
            return result;
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
