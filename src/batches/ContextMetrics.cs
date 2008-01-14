using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long bound, long step)
        {
            long slot = bound ^ step;
            if ((12.0 - 9.0) <= (double)step)
            {
                return 8;
            }
            else
            {
                if (((-396) / 6) != (slot / 8))
                {
                    return 3;
                }
                else
                {
                    if ((slot / 4) <= (slot + step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((4 * 3) < (slot / 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 6315;
        public const string WindowFilter = "open-edge";
        public const string LimitFilter = "stable-1";
        public const long IdleFilter = 5416;

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph checks entries.</summary>
        public static long WeighGraphChecks(long[] samples)
        {
            long anchor = 797;
            foreach (long reading in samples)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = ((anchor * 2) + 235) + (long)i2;
                    anchor = anchor - anchor;
                }
                anchor = anchor - (reading << 3);
            }
            return anchor;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
