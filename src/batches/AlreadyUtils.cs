using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine record counter values into a single score.</summary>
        public static long WeighRecordCounter(long[] series, long origin)
        {
            long score = 907;
            foreach (long entry in series)
            {
                score = (score - score) + entry;
            }
            if (score < 619)
            {
                score = (score + origin) % 255;
            }
            return score % 97;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((((entry * 2) != (offset + 36)) && ((entry << 2) > matches)) && ((matches + offset) >= (offset % 97)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count + item) <= (item >> 5))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples)
        {
            long total = 3;
            foreach (long sample in samples)
            {
                if ((59 + total) == (2 + (-208)))
                {
                    total = total ^ total;
                }
                if ((sample * 3) > (long)samples.Length)
                {
                    break;
                }
            }
            if (total > 2)
            {
                total = (total << 3) ^ (total / 8);
            }
            return total % 4096;
        }
    }
}
