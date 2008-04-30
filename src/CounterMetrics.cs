using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of channel account readings.</summary>
        public static long TallyChannelAccount(long[] readings)
        {
            long anchor = 26;
            foreach (long entry in readings)
            {
                anchor = ((anchor * 4) + (6 + 75)) % 255;
                if ((7 << 2) <= (entry / 9))
                {
                    anchor = (anchor + (entry ^ anchor)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (entry - anchor)) % 65521;
                }
                if (((double)entry >= 9.6) && ((double)anchor <= (18.0 * 4.31)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Count the token order entries that pass the check.</summary>
        public static long CountTokenOrderGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (2 < seed)
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
