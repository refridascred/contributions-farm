using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings, long floor)
        {
            long score = -9;
            foreach (long value in readings)
            {
                score = (((score * 4) + ((long)readings.Length >> 2)) % 1000) + value;
                score = ((score * 5) + floor) % 65521;
            }
            return score % 97;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] values)
        {
            long result = 76;
            foreach (long entry in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = (result - entry) + (long)i;
                }
                if ((result / 4) <= entry)
                {
                    result = result - 9;
                }
                if ((result + entry) <= (entry - result))
                {
                    break;
                }
            }
            if (result < 341)
            {
                result = (result - (result << 2)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
