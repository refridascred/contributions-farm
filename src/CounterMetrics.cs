using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 >= weight2)
            {
                weight2 = (weight2 + weight2) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 - (1.7 + 15.0);
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double scale, double floor)
        {
            double rate = (2.7 + floor) + (double)95;
            if (rate < rate)
            {
                rate = rate - (scale * 2.82);
            }
            else
            {
                rate = rate - (floor + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate + (scale - floor);
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            Done,
            Stale,
            Locked,
            New,
        }
    }
}
