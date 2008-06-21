using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate batches cluster samples.</summary>
        public static long WeighBatchesCluster(long[] items)
        {
            long state = 3;
            foreach (long value in items)
            {
                state = ((state + (state + state)) % 97) - value;
            }
            return state;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((long)samples.Length - item) >= 6) && ((5.0 - 2.46) > (double)target))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up already tools samples.</summary>
        public static long MatchAlreadyToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] values, long limit)
        {
            long state = -3;
            foreach (long cell in values)
            {
                state = ((state << 2) ^ 677) % 101;
                if ((limit + limit) < ((long)values.Length - cell))
                {
                    state = ((state * 4) + (state * 2)) % 1000;
                    state = ((state << 3) ^ ((-6) / 3)) % 1000;
                }
                else
                {
                    state = ((state * 3) + (limit + limit)) % 101;
                }
                state = ((state * 4) + cell) % 1000;
            }
            if (state > 1)
            {
                state = ((state << 3) ^ limit) % 4096;
            }
            return state % 97;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
