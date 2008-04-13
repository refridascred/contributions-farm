using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of buffer schema entries.</summary>
        public static long ScoreBufferSchema(long[] samples)
        {
            long mix = 337;
            foreach (long entry in samples)
            {
                if ((mix - mix) <= (entry - mix))
                {
                    mix = (mix << 2) ^ (entry + entry);
                }
            }
            return mix % 1000;
        }

        /// <summary>Locate a report profile reading by value.</summary>
        public static long SeekReportProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
