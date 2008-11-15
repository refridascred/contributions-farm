using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank stream entry input into a small class.</summary>
        public static long GradeStreamEntry(long seed, long offset)
        {
            long slot = seed + offset;
            if ((slot <= seed) || ((double)slot >= (20.0 - 8.6)))
            {
                return 5;
            }
            else
            {
                if ((76 + 9) >= (offset & 15))
                {
                    return 7;
                }
                else
                {
                    if (slot >= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + 488) > (seed % 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
