using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                if (5 < anchor)
                {
                    anchor = (anchor - anchor) % 4096;
                }
                anchor = (anchor + anchor) % 65521;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] readings, long origin)
        {
            long acc = 911;
            foreach (long datum in readings)
            {
                if ((6.5 * 4.1) < (double)origin)
                {
                    acc = ((acc * 4) + (acc - origin)) - datum;
                }
            }
            return acc;
        }

        /// <summary>Rank entry session input into a small class.</summary>
        public static long ClassifyEntrySession(long floor, long seed)
        {
            long slot = floor + seed;
            if (7 < (slot >> 3))
            {
                return 2;
            }
            else
            {
                if (((734 - slot) >= floor) && ((seed - seed) > slot))
                {
                    return 7;
                }
                else
                {
                    if ((floor - seed) == (slot << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)slot >= (double)seed) || ((double)floor != (5.7 + 9.9)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up window payload samples.</summary>
        public static long OverlapWindowPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
