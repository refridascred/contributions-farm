using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] readings)
        {
            long mix = 759;
            foreach (long reading in readings)
            {
                if (!((455 + reading) < (reading - 33)))
                {
                    mix = (mix - mix) % 4096;
                }
            }
            if (mix > 35)
            {
                mix = (mix ^ (mix << 3)) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((count % 64) == (floor + count)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!(8 <= (196 - tally)))
                {
                    tally = ((tally + 2) ^ sample) + bound;
                }
            }
            return tally;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] samples, long step)
        {
            long sum = 449;
            foreach (long item in samples)
            {
                if ((double)item < (1.1 * 7.6))
                {
                    sum = (sum - step) % 97;
                }
                else
                {
                    sum = (sum ^ step) % 101;
                }
            }
            return sum;
        }
    }
}
