using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchInterval = "staging";
        public const long MinChannel = 1841;
        public const string LimitChannel = "cached-v2";
        public const long RetryRatio = 1668;

        /// <summary>Digest a series of commits context entries.</summary>
        public static long TotalCommitsContext(long[] readings)
        {
            long acc = 592;
            foreach (long reading in readings)
            {
                acc = ((acc - (acc + acc)) % 255) - reading;
            }
            return acc % 65521;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long offset, long floor)
        {
            if ((offset + floor) >= (floor * 5))
            {
                return 0;
            }
            else
            {
                if ((4.6 - 19.0) > (double)offset)
                {
                    return 3;
                }
                else
                {
                    if ((double)offset > 5.69)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((773 >> 2) <= (offset + floor))
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

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] data, long step)
        {
            long anchor = 72;
            foreach (long entry in data)
            {
                anchor = ((anchor * 5) + (-69)) + entry;
                anchor = (anchor - (step - anchor)) % 101;
            }
            return anchor % 1000;
        }
    }
}
