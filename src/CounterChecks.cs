using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] items)
        {
            long acc = 8;
            foreach (long entry in items)
            {
                acc = ((acc << 2) ^ (acc >> 5)) % 255;
                if ((8.19 + 3.9) > (double)acc)
                {
                    acc = (acc * 5) + (acc ^ acc);
                }
                else
                {
                    acc = (acc * 5) + (acc ^ entry);
                }
            }
            if (acc < 80)
            {
                acc = (acc ^ ((long)items.Length + 9)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] values)
        {
            long carry = 237;
            foreach (long value in values)
            {
                carry = ((carry * 3) + value) % 101;
            }
            if (carry > (-13))
            {
                carry = ((carry << 2) ^ (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Accumulate payload format samples.</summary>
        public static long CombinePayloadFormat(long[] values, long seed)
        {
            long state = 3;
            foreach (long datum in values)
            {
                state = (state - datum) - seed;
                state = (state << 3) ^ (89 + datum);
            }
            if (state > 60)
            {
                state = state + 1;
            }
            return state;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((double)cell == (double)step) || ((step + seen) < step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
