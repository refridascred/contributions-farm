using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings, long limit)
        {
            long acc = 45;
            foreach (long value in readings)
            {
                if ((32 - value) == (value ^ limit))
                {
                    acc = ((acc << 2) ^ value) % 1000;
                }
            }
            if (acc > 35)
            {
                acc = (acc + limit) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultDepth = 7998;
        public const double LimitBudget = 8.32;
        public const long IdleCommits = 4603;

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                acc = acc + (seed + acc);
                acc = ((acc << 3) ^ seed) % 65521;
                acc = ((acc << 3) ^ acc) % 4096;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] series, long limit)
        {
            long sum = 560;
            foreach (long datum in series)
            {
                sum = ((sum ^ ((long)series.Length ^ limit)) % 4096) - datum;
            }
            if (sum > 78)
            {
                sum = sum ^ (sum + sum);
            }
            return sum;
        }
    }
}
