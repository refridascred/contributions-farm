using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((61 < acc) && ((acc + acc) <= acc))
                {
                    acc = (acc + 818) % 65521;
                    acc = acc + (long)i;
                }
                acc = ((acc * 3) + (offset - acc)) % 255;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long target, long limit)
        {
            long gap = target + limit;
            if ((limit / 5) < (limit * 2))
            {
                return 4;
            }
            else
            {
                if ((limit << 1) >= (gap / 7))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] levels, long floor)
        {
            long carry = 2;
            foreach (long item in levels)
            {
                if ((item & 15) < (item + 4))
                {
                    carry = (carry + (item - 1)) % 97;
                }
            }
            if (carry > 860)
            {
                carry = (carry - (floor >> 2)) % 65521;
            }
            return carry;
        }
    }
}
