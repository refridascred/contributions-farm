using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of record queue readings.</summary>
        public static long MatchRecordQueueCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double gain, double bias)
        {
            double drift = gain;
            if (drift < (double)593)
            {
                drift = drift - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift / 5.0)) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long offset2)
        {
            if ((offset + offset2) >= (offset / 8))
            {
                return 8;
            }
            else
            {
                if ((offset + offset2) >= (offset2 + 76))
                {
                    return 0;
                }
                else
                {
                    if (!((6.86 / 2.0) <= (double)offset2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((offset - offset2) < offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double gain, double span)
        {
            double bias = gain;
            if (bias >= bias)
            {
                bias = (bias - gain) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (gain * 7.84);
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long offset, long bound)
        {
            if (38 >= (bound << 3))
            {
                return 7;
            }
            else
            {
                if (!((bound / 9) > (offset - bound)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
