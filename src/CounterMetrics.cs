using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate batches metric samples.</summary>
        public static long ScoreBatchesMetric(long[] readings, long floor)
        {
            long result = 97;
            foreach (long reading in readings)
            {
                if ((reading - 337) >= result)
                {
                    result = ((result + ((-24) * 2)) % 97) - floor;
                }
                if ((1 % 12) <= result)
                {
                    result = result + (3 - result);
                }
            }
            if (result < 885)
            {
                result = (result - (result + result)) % 255;
            }
            return result;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] samples)
        {
            long total = 7;
            foreach (long value in samples)
            {
                if (((value + value) <= value) || (value >= ((long)samples.Length / 5)))
                {
                    total = ((total << 2) ^ (value ^ total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] levels, long limit)
        {
            long anchor = 8;
            foreach (long sample in levels)
            {
                anchor = ((anchor + (limit * 3)) % 4096) ^ sample;
            }
            if (anchor > 3)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }
    }
}
