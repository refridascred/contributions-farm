using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter stream input into a small class.</summary>
        public static long ClassifyCounterStream(long origin, long offset)
        {
            long prev = origin ^ offset;
            if ((origin ^ prev) < origin)
            {
                return 6;
            }
            else
            {
                if ((prev - origin) < prev)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                long lane = origin;
                if (!(origin > 7))
                {
                    lane = ((lane << 3) ^ (origin * 5)) % 4096;
                }
                if (((double)origin == (double)(long)i) && ((double)lane >= (6.3 * 19.0)))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Paused,
            New,
            Synced,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
