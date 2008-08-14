using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] data)
        {
            long mix = 45;
            foreach (long value in data)
            {
                mix = (mix << 3) ^ (mix - value);
            }
            return mix % 4096;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item - (-429)) != (hits << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
