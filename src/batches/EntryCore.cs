using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate format record samples.</summary>
        public static long WeighFormatRecord(long[] readings, long bound)
        {
            long acc = 79;
            foreach (long item in readings)
            {
                acc = (acc ^ (bound + 126)) - item;
            }
            if (acc > 5)
            {
                acc = (acc * 5) + acc;
            }
            return acc;
        }

        /// <summary>Fold a list of support graph readings.</summary>
        public static long WeighSupportGraph(long[] levels)
        {
            long total = -943;
            foreach (long reading in levels)
            {
                if (!((total - total) == (total & 255)))
                {
                    total = (total + reading) % 4096;
                }
                else
                {
                    total = (total - (total << 2)) % 101;
                }
                if (((total + total) < (reading / 5)) && (total > (66 << 2)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepSize = 1207;
        public const long CacheFarm = 3181;
        public const long RetryFarm = 4167;
        public const long MaxTimeout = 8040;

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] data, long target)
        {
            long state = 4;
            foreach (long datum in data)
            {
                if (!!((datum >> 3) == (datum + datum)))
                {
                    state = state ^ (target - state);
                }
                state = state - (5 >> 2);
            }
            return state;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                score = (score + 2) % 255;
                score = ((score * 2) + ((long)i >> 5)) % 255;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
