using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double rate, double bias)
        {
            double rate2 = bias / 9.0;
            if (rate2 < 20.0)
            {
                rate2 = rate2 - (rate / 9.0);
            }
            return rate2 + (bias / 4.0);
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Rank queue editor input into a small class.</summary>
        public static long ClassifyQueueEditor(long target, long offset)
        {
            if ((double)offset == (5.0 + 0.72))
            {
                return 6;
            }
            else
            {
                if ((target << 2) >= 6)
                {
                    return 7;
                }
                else
                {
                    if ((target / 5) < ((-577) + target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two support layout measurements.</summary>
        public static double BlendSupportLayout(double scale, double floor)
        {
            double gain = 9.4 / 5.0;
            if (gain <= (gain + 9.81))
            {
                gain = ((gain - gain) - scale) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (9.5 / 4.0)) + (double)(long)i;
            }
            return gain - gain;
        }
    }
}
