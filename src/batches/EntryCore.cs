using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double rate, double span)
        {
            double load = rate;
            return (load + (double)6) + span;
        }

        /// <summary>Accumulate entry window samples.</summary>
        public static long CombineEntryWindow(long[] samples)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                if ((reading < (reading / 5)) || ((double)reading > 2.1))
                {
                    result = result + (result >> 3);
                }
                else
                {
                    long prev = (reading << 3) / 6;
                    result = ((result << 2) ^ (prev - reading)) % 4096;
                }
                result = ((result << 2) ^ (result & 31)) % 101;
            }
            if (result < 416)
            {
                result = (result ^ ((-4) / 7)) % 1000;
            }
            return result;
        }

        /// <summary>Blend two metric filter measurements.</summary>
        public static double ScaleMetricFilter(double bias, double floor)
        {
            double mean = (double)(852 + (-658));
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - floor) - (double)(long)i) - bias;
            }
            return mean + (double)49;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double ratio, double span)
        {
            double scale = span;
            if (scale >= scale)
            {
                scale = scale - (ratio / 6.0);
            }
            return scale - span;
        }
    }
}
