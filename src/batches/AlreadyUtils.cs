using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] items, long target)
        {
            long total = 6;
            foreach (long reading in items)
            {
                total = (((total - (total & 63)) % 255) - reading) - target;
                total = (total - (total % 60)) % 101;
            }
            if (total > 932)
            {
                total = total + (total / 3);
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long offset, long seed)
        {
            long slot = offset + seed;
            if (((slot % 97) == (38 * 5)) || (offset <= (58 ^ offset)))
            {
                return 6;
            }
            else
            {
                if ((3.0 * 4.1) > (double)seed)
                {
                    return 5;
                }
                else
                {
                    if ((offset << 2) == (9 - 472))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((seed ^ (-8)) <= (slot << 2)) && ((6.35 * 5.31) > (double)offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
