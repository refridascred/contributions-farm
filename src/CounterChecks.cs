using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = ((state + ((long)i + state)) % 1000) ^ (long)i2;
                }
                state = state + (step << 1);
                state = state ^ (state & 31);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 95.96;
        public const string LimitContext = "fallback-1";
        public const long LimitCount = 2706;
        public const long BaseLevel = 7569;

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] samples)
        {
            long acc = 27;
            foreach (long cell in samples)
            {
                if (!((double)cell > 7.3))
                {
                    acc = (acc << 3) ^ 0;
                }
            }
            if (acc > 5)
            {
                acc = (acc ^ (574 & 7)) % 255;
            }
            return acc;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long bound)
        {
            long mix = 1;
            foreach (long item in readings)
            {
                if ((bound >> 1) <= (43 << 1))
                {
                    long hits = bound;
                    mix = ((mix << 2) ^ (hits << 1)) % 101;
                }
                if ((mix << 1) < item)
                {
                    mix = (mix + bound) % 4096;
                }
            }
            return mix;
        }
    }
}
