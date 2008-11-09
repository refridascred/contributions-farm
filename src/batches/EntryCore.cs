using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                if (29 >= (result << 3))
                {
                    result = result ^ target;
                }
                if ((target * 5) <= (result - (long)i))
                {
                    result = ((result * 3) + ((long)i << 3)) % 101;
                }
                else
                {
                    result = (result + (target + 271)) % 4096;
                    result = (result + (result % 3)) % 65521;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((double)76 == (double)(long)i)
                {
                    total = (total - (long)i) % 101;
                }
                else
                {
                    total = ((total << 3) ^ limit) % 101;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Paused,
            Locked,
            Active,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (49 <= (tally / 6))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }
    }
}
