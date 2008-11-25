using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long floor, long offset)
        {
            long prev = floor + offset;
            if (prev <= (offset / 7))
            {
                return 3;
            }
            else
            {
                if (floor < 75)
                {
                    return 6;
                }
                else
                {
                    if ((floor + floor) >= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset - floor) != (offset + floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Pending,
            Locked,
            Draft,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)sample >= (7.35 - 6.37))
                {
                    tally = (tally + 3) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
