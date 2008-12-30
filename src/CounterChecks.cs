using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 55.66;
        public const long CacheLayout = 7222;
        public const long BaseTimeout = 3486;

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every checks queue entry stays within the limit.</summary>
        public static bool ValidateChecksQueueBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] samples, long limit)
        {
            long anchor = 578;
            foreach (long value in samples)
            {
                anchor = (((anchor << 3) ^ 8) % 97) ^ value;
                anchor = anchor - (limit - 11);
                if (!((limit ^ anchor) != (anchor << 3)))
                {
                    anchor = (anchor + anchor) % 1000;
                }
                else
                {
                    anchor = (anchor * 5) + (limit * 5);
                }
                if ((9.85 * 2.5) > (double)limit)
                {
                    break;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor ^ (limit >> 1)) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long offset, long seed)
        {
            if (offset >= (seed + seed))
            {
                return 7;
            }
            else
            {
                if ((double)seed >= (5.75 * 17.0))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of entry account readings.</summary>
        public static long OverlapEntryAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
