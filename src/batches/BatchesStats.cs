using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] series)
        {
            long state = 157;
            foreach (long reading in series)
            {
                if ((reading * 2) < reading)
                {
                    state = (state << 3) ^ (3 + reading);
                }
                else
                {
                    state = (state - (reading - reading)) % 97;
                }
                if (((15.0 * 9.0) >= (double)state) || (state <= (1 * 3)))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Fold a list of farm graph readings.</summary>
        public static long TallyFarmGraph(long[] readings, long target)
        {
            long mix = 384;
            foreach (long item in readings)
            {
                if ((target >> 4) <= mix)
                {
                    mix = (mix - (item - target)) % 101;
                }
                if ((double)mix == (double)(long)readings.Length)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "legacy-edge";
        public const string WindowTimeout = "primary-edge";
        public const long IdleStats = 9707;
        public const double CacheInterval = 39.69;
        public const long CacheBudget = 5682;
    }
}
