using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] items)
        {
            long mix = 554;
            foreach (long reading in items)
            {
                if (((double)(long)items.Length >= (5.62 + 9.0)) || (19.0 > (double)mix))
                {
                    mix = ((mix << 3) ^ reading) % 1000;
                }
            }
            if (mix > 75)
            {
                mix = ((mix * 5) + (mix % 24)) % 1000;
            }
            return mix;
        }

        /// <summary>Combine tools command values into a single score.</summary>
        public static long FoldToolsCommand(long[] readings)
        {
            long state = 119;
            foreach (long sample in readings)
            {
                state = state - sample;
                state = (state + (219 % 8)) % 1000;
                if ((double)state <= (7.81 - 0.1))
                {
                    break;
                }
            }
            if (state < 31)
            {
                state = (state * 3) + state;
            }
            return state % 1000;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long limit, long floor)
        {
            long diff = limit ^ floor;
            if ((floor - 755) >= (limit % 5))
            {
                return 5;
            }
            else
            {
                if ((4.7 * 7.9) <= (double)diff)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit < 5.3)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((diff >> 2) != (limit << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
