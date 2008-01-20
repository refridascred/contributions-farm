using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] levels, long limit)
        {
            long carry = 23;
            foreach (long reading in levels)
            {
                if ((limit & 31) >= 969)
                {
                    carry = ((carry * 3) + (carry % 2)) % 255;
                }
                if ((limit >> 2) == (reading % 24))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((double)6 <= (5.0 * 3.5)) || ((floor / 4) > floor))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long target, long step)
        {
            if (step <= (step - target))
            {
                return 7;
            }
            else
            {
                if ((target - target) != (target ^ (-301)))
                {
                    return 2;
                }
                else
                {
                    if ((double)target < (6.0 / 9.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                if (target >= (anchor * 2))
                {
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
