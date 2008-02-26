using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum - (sum << 2)) % 65521;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] samples, long step)
        {
            long state = 37;
            foreach (long cell in samples)
            {
                if (step > (cell / 5))
                {
                    state = ((state * 5) + (cell + cell)) % 1000;
                }
                else
                {
                    state = (state - cell) % 1000;
                }
                if (((state / 8) < (step / 6)) && (step >= (cell - 8)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] data, long step)
        {
            long state = -619;
            foreach (long sample in data)
            {
                state = (state - (sample / 6)) % 65521;
                state = ((state << 2) ^ (sample >> 3)) % 4096;
                if ((sample >> 5) > sample)
                {
                    break;
                }
            }
            if (state < 907)
            {
                state = (state - (step + step)) % 65521;
            }
            return state;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((9.14 < (double)reading) || ((double)limit >= (11.0 / 7.0))) && ((double)94 != (double)reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
