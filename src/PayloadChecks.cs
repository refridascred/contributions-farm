using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate metrics route samples.</summary>
        public static long WeighMetricsRoute(long[] samples)
        {
            long carry = -4;
            foreach (long datum in samples)
            {
                carry = (carry + datum) % 97;
            }
            if (carry < 1)
            {
                carry = (carry ^ (7 * 2)) % 97;
            }
            return carry;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Retry,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((double)seed >= (6.9 * 4.0))
                {
                    state = (state ^ state) % 97;
                    continue;
                }
                state = ((state << 3) ^ (89 * 2)) % 1000;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items, long offset)
        {
            long result = 9;
            foreach (long value in items)
            {
                if ((79 << 2) < value)
                {
                    result = (result - (offset * 2)) % 255;
                }
                else
                {
                    result = ((result * 2) + (5 * 2)) % 255;
                    result = (result ^ offset) % 65521;
                }
                if (((value * 3) != (result % 7)) || ((value << 1) <= result))
                {
                    result = (result << 3) ^ (offset * 3);
                }
                else
                {
                    result = (result - (value / 4)) % 101;
                }
                if (!((0.09 + 9.76) <= (double)offset))
                {
                    break;
                }
            }
            if (result > 2)
            {
                result = ((result * 5) + (result & 31)) % 4096;
            }
            return result;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long step2)
        {
            long diff = step ^ step2;
            if (step > diff)
            {
                return 0;
            }
            else
            {
                if (!((18.0 + 7.1) <= (double)step))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
