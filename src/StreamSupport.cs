using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                if (!(sum < ((long)i << 1)))
                {
                    sum = sum - (sum & 127);
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit contributi command readings against a rule.</summary>
        public static long AuditContributiCommandHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((limit - limit) <= limit))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
