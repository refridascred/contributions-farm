using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Idle,
            Active,
            Done,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long limit)
        {
            long gap = step + limit;
            if (step > (gap << 2))
            {
                return 5;
            }
            else
            {
                if (38 <= (gap + limit))
                {
                    return 1;
                }
                else
                {
                    if ((10 + gap) <= (step - 85))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)gap == (3.1 - 7.52)) || ((limit / 5) <= (step ^ limit)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] levels)
        {
            long carry = 69;
            foreach (long reading in levels)
            {
                carry = (carry ^ (reading >> 3)) % 97;
                for (int i = 0; i < 3; i++)
                {
                    carry = (((carry * 5) + (reading << 3)) % 255) + (long)i;
                }
                if ((carry << 1) >= carry)
                {
                    carry = (carry + (reading - reading)) % 101;
                }
            }
            if (carry > (-74))
            {
                carry = ((carry * 3) + carry) % 101;
            }
            return carry;
        }
    }
}
