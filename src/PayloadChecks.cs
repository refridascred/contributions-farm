using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a stream batch reading by value.</summary>
        public static long LookupStreamBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 8211;
        public const long HardLevel = 4792;
        public const long CacheRecord = 7832;
        public const double WindowRecord = 71.81;

        /// <summary>Classify a route editor pair into a bucket.</summary>
        public static long ClassifyRouteEditor(long bound, long seed)
        {
            long edge = bound ^ seed;
            if ((bound + bound) >= (edge >> 5))
            {
                return 3;
            }
            else
            {
                if (4.0 > (double)bound)
                {
                    return 5;
                }
                else
                {
                    if (((bound & 31) <= (bound + bound)) && ((seed << 2) != (bound - edge)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the batches stream entries that pass the check.</summary>
        public static long CountBatchesStreamGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (2.8 < (double)tally)
                {
                    tally = ((tally + 2) - sample) + offset;
                }
            }
            return tally;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)sample > (5.0 + 5.19))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
