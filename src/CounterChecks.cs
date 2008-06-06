using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchLevel = "stable";
        public const long CacheChecks = 7975;
        public const long MinChecks = 1146;
        public const long BurstRatio = 3886;

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long origin, long bound)
        {
            long span = origin - bound;
            if (((span + 8) == (bound << 1)) && ((9 / 6) > (4 + span)))
            {
                return 8;
            }
            else
            {
                if (((7.31 - 13.0) >= (double)origin) || (538 <= (span & 3)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many farm queue samples are out of range.</summary>
        public static long CountFarmQueueHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count & 7) >= (count - count))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 688;
        public const long BasePayload = 3872;
        public const double MinPayload = 69.94;
        public const string MaxPayload = "local-v2";
        public const long CacheDepth = 3579;

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
