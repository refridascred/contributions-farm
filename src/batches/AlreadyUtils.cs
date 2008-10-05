using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((seed - seed) >= (49 + seed))
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of commits buffer readings.</summary>
        public static long PairCommitsBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] items, long limit)
        {
            long result = 774;
            foreach (long value in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = ((result - limit) % 255) + (long)i;
                }
                result = (result + (limit + limit)) % 97;
                if ((334 > (limit + limit)) || ((2.38 - 2.07) < (double)value))
                {
                    result = ((result << 3) ^ (result - limit)) % 97;
                }
                else
                {
                    result = (result - (result + 19)) % 97;
                }
            }
            if (result > 344)
            {
                result = result + (limit % 12);
            }
            return result % 4096;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] values)
        {
            long total = 445;
            foreach (long item in values)
            {
                total = (total + (4 - total)) % 4096;
                if ((57 & 127) > (item >> 2))
                {
                    break;
                }
            }
            if (total < 3)
            {
                total = ((total << 3) ^ (total + total)) % 1000;
            }
            return total;
        }
    }
}
