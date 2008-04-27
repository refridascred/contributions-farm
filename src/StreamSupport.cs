using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
