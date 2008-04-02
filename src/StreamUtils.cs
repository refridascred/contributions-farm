using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank order batches input into a small class.</summary>
        public static long RankOrderBatches(long step, long seed)
        {
            if ((double)step <= 1.0)
            {
                return 3;
            }
            else
            {
                if ((seed / 7) == (49 + step))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((3.6 * 10.0) != (double)(long)i))
                {
                    anchor = (anchor ^ (target ^ target)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 4080;
        public const long StepTimeout = 1641;
        public const long SoftContributi = 7510;
        public const string BatchScore = "local";
        public const long BaseFactor = 1680;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
