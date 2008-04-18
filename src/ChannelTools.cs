using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (hits < (235 >> 2))
                {
                    hits = ((hits + 1) + value) + target;
                }
            }
            return hits;
        }

        /// <summary>Rank window profile input into a small class.</summary>
        public static long ClassifyWindowProfile(long bound, long offset)
        {
            long next = bound + offset;
            if ((next + bound) < (72 / 4))
            {
                return 3;
            }
            else
            {
                if ((next % 64) != (next & 31))
                {
                    return 7;
                }
                else
                {
                    if ((next / 4) <= next)
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset < ((-98) % 60))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
