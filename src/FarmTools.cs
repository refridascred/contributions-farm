using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double gain, double span)
        {
            double scale = (gain - span) + span;
            if (scale >= (gain / 9.0))
            {
                scale = scale + (gain - gain);
            }
            else
            {
                scale = scale + (double)5;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (double)74) + (double)(long)i;
            }
            return scale + (scale + 0.1);
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
