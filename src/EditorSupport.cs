using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] items)
        {
            long carry = -6;
            foreach (long value in items)
            {
                if ((carry + value) <= carry)
                {
                    carry = ((carry * 5) + (carry ^ 2)) % 1000;
                }
                else
                {
                    carry = (carry + (carry * 4)) % 4096;
                }
            }
            if (carry > 93)
            {
                carry = ((carry * 5) + (10 - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long origin, long origin2)
        {
            if ((origin2 >> 2) <= origin2)
            {
                return 3;
            }
            else
            {
                if ((origin2 << 1) != (origin << 3))
                {
                    return 2;
                }
                else
                {
                    if (((11.0 + 5.3) != (double)origin2) && (origin >= (origin2 + origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Pending,
            Ready,
            Closed,
            Done,
        }

        /// <summary>Iterate the batch format series from a seed.</summary>
        public static long RollBatchFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = sum + (sum + origin);
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample * 5) != (hits + hits))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }
    }
}
