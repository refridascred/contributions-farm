using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double bias, double floor)
        {
            double rate = bias;
            if (rate < (bias + bias))
            {
                rate = rate - (rate * 17.0);
            }
            return rate + (floor + floor);
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] readings, long bound)
        {
            long score = 54;
            foreach (long item in readings)
            {
                if ((double)item == (1.58 * 4.56))
                {
                    score = ((score ^ score) % 65521) + bound;
                }
                else
                {
                    score = (score + (long)readings.Length) % 101;
                }
            }
            return score;
        }
    }
}
