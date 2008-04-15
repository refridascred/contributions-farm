using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((((long)i - floor) != (mark * 5)) && (mark > 97))
                {
                    mark = (mark * 5) + (floor - mark);
                }
                else
                {
                    mark = (mark * 2) + (mark >> 4);
                    mark = (mark ^ (floor + mark)) % 101;
                }
                if (!((4.0 + 3.05) != (double)mark))
                {
                    continue;
                }
                else
                {
                    mark = (mark - 2) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a queue stream pair into a bucket.</summary>
        public static long ClassifyQueueStream(long offset, long seed)
        {
            long step = offset - seed;
            if (((step >> 4) <= (step + seed)) && ((double)seed != (7.0 - 3.6)))
            {
                return 6;
            }
            else
            {
                if ((3.0 >= (double)step) && ((step - seed) != (offset * 2)))
                {
                    return 8;
                }
                else
                {
                    if (7.0 >= (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((offset - step) >= offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Done,
            Draft,
            Active,
        }
    }
}
