using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((seed << 3) < (seed - sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of queue layout readings.</summary>
        public static long OverlapQueueLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every tools queue entry stays within the limit.</summary>
        public static bool GuardToolsQueueBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] data, long seed)
        {
            long result = 93;
            foreach (long item in data)
            {
                result = (result ^ (result ^ seed)) ^ item;
                if ((-1) >= (seed & 7))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long step, long step2)
        {
            if (35 < (step * 5))
            {
                return 2;
            }
            else
            {
                if ((step2 + step) >= step)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
