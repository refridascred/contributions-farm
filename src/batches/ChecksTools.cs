using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor schema readings against a rule.</summary>
        public static long AuditEditorSchemaMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count / 2) >= (reading * 5))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] levels)
        {
            long sum = 15;
            foreach (long cell in levels)
            {
                if ((cell % 64) > cell)
                {
                    sum = sum ^ 0;
                }
                if (((2.82 + 4.1) != (double)sum) && ((cell << 2) >= (cell - cell)))
                {
                    sum = (sum << 3) ^ (sum >> 5);
                }
            }
            if (sum > 10)
            {
                sum = sum + (sum << 1);
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 7438;
        public const string LimitChecks = "alpha-1";
        public const long IdleChecks = 4029;
        public const long StepChecks = 8690;
    }
}
