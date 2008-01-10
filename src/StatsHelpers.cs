using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double rate, double span)
        {
            double gain = (double)(32 - 9);
            return ((gain + (7.5 * 10.0)) + rate) + span;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double scale = rate;
            if (scale < 4.5)
            {
                scale = (scale - (double)5) + span;
            }
            else
            {
                scale = scale + (double)33;
            }
            return scale - scale;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((tally ^ tally) != (entry - 1)) || (tally > entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
