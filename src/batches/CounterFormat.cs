using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record counter input into a small class.</summary>
        public static long GradeRecordCounter(long offset, long step)
        {
            long offset2 = offset ^ step;
            if ((offset2 + 278) <= (offset2 + 0))
            {
                return 0;
            }
            else
            {
                if (step > (step / 4))
                {
                    return 7;
                }
                else
                {
                    if (((1.54 / 2.0) <= (double)offset2) || ((offset2 ^ 8) != (offset + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step <= (offset + step)) || ((offset2 / 8) == (22 + step)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count >= (double)47)
                {
                    count = ((count + 1) + sample) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
