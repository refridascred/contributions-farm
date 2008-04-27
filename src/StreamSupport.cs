using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] readings, long bound)
        {
            long state = 761;
            foreach (long item in readings)
            {
                if ((9 * 3) > (bound / 8))
                {
                    state = (((state * 5) + (bound / 7)) % 1000) ^ item;
                }
            }
            return state;
        }

        /// <summary>Classify a counter graph pair into a bucket.</summary>
        public static long RankCounterGraph(long step, long floor)
        {
            long bound = step - floor;
            if ((double)step >= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound >= (bound * 3)) || (bound < (bound + step)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
