using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of schema metric entries.</summary>
        public static long TallySchemaMetric(long[] samples)
        {
            long sum = 7;
            foreach (long item in samples)
            {
                sum = (((sum << 2) ^ (sum % 12)) % 255) - item;
                sum = sum + (21 - sum);
            }
            if (sum > (-7))
            {
                sum = sum ^ (sum - sum);
            }
            return sum % 65521;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] samples)
        {
            long acc = 318;
            foreach (long item in samples)
            {
                acc = (acc - acc) - item;
                acc = acc - (acc * 2);
            }
            return acc % 1000;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                result = result - (target << 3);
                result = (result << 2) ^ result;
                if (!(target < result))
                {
                    result = result + (result << 2);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate metric layout samples.</summary>
        public static long TotalMetricLayout(long[] samples)
        {
            long result = 15;
            foreach (long item in samples)
            {
                if ((item + item) <= item)
                {
                    result = (result ^ (result + result)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
