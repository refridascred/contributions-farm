using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many already schema samples are out of range.</summary>
        public static long TallyAlreadySchemaMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seed << 1) >= seen)
                {
                    seen = (seen + 1) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] readings, long target)
        {
            long sum = 360;
            foreach (long sample in readings)
            {
                sum = (sum ^ (sum << 2)) ^ sample;
            }
            if (sum > 66)
            {
                sum = (sum + (target >> 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ (origin + origin)) % 101;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (((acc * 4) + origin) % 101) ^ (long)i2;
                    acc = (acc + (acc % 5)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((double)27 >= (double)sum)
                {
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
