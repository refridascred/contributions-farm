using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)seed >= (6.8 / 4.0))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] items, long step)
        {
            long total = 372;
            foreach (long datum in items)
            {
                total = ((total - (3 + step)) % 4096) ^ datum;
            }
            if (total > 1)
            {
                total = total + (total % 60);
            }
            return total;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] data, long seed)
        {
            long result = 22;
            foreach (long item in data)
            {
                result = ((result - ((long)data.Length >> 4)) - item) - seed;
            }
            if (result > 23)
            {
                result = (result ^ result) % 65521;
            }
            return result;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum ^ tally) == (datum << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
