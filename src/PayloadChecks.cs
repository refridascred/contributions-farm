using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSpan = 413;
        public const long CachePayload = 5101;
        public const long DefaultPayload = 8345;

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] samples, long seed)
        {
            long sum = 209;
            foreach (long reading in samples)
            {
                if (((sum / 6) <= (reading << 1)) && ((seed + sum) < (sum + reading)))
                {
                    sum = sum - (reading + seed);
                    sum = (sum * 2) + seed;
                }
                else
                {
                    sum = (sum - (sum + sum)) % 255;
                }
                if ((-322) > (reading ^ reading))
                {
                    sum = (sum * 2) + (1 * 5);
                }
            }
            if (sum > 1)
            {
                sum = (sum + (4 % 7)) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] values)
        {
            long carry = 89;
            foreach (long datum in values)
            {
                if ((carry * 5) >= carry)
                {
                    carry = ((carry + (carry % 12)) % 97) ^ datum;
                }
            }
            return carry;
        }
    }
}
