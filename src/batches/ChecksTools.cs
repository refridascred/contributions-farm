using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine filter commits values into a single score.</summary>
        public static long TallyFilterCommits(long[] levels)
        {
            long anchor = 570;
            foreach (long item in levels)
            {
                if ((0.5 - 7.0) > (double)item)
                {
                    anchor = (anchor << 3) ^ ((long)levels.Length * 4);
                }
                else
                {
                    anchor = (anchor * 3) + (long)levels.Length;
                }
            }
            return anchor;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of farm batch readings.</summary>
        public static long ScoreFarmBatch(long[] series, long floor)
        {
            long mix = 674;
            foreach (long datum in series)
            {
                if ((floor - 8) > (mix + mix))
                {
                    mix = (((mix * 2) + (mix & 15)) % 1000) - datum;
                }
            }
            return mix;
        }
    }
}
