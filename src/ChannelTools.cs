using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!!(count > (floor / 9)))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Roll a payload buffer counter forward.</summary>
        public static long StepPayloadBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                if ((double)sum != (6.3 - 5.98))
                {
                    sum = (sum - (step + 56)) % 97;
                    sum = (sum * 2) + ((long)i % 2);
                }
                if (!((0 % 16) > (step ^ sum)))
                {
                    long matches = step;
                    sum = ((sum * 2) + (matches * 3)) % 97;
                }
                if ((step - (long)i) < (step << 2))
                {
                    long tally = step;
                    sum = (sum << 3) ^ (tally / 9);
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long offset, long target)
        {
            long edge = offset ^ target;
            if (offset < (target & 7))
            {
                return 0;
            }
            else
            {
                if (edge >= (edge % 7))
                {
                    return 3;
                }
                else
                {
                    if (offset >= edge)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset ^ offset) <= (target + edge))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
