using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long offset, long seed)
        {
            long span = offset - seed;
            if (((span ^ span) >= (span + 560)) || ((seed - offset) <= (span + offset)))
            {
                return 2;
            }
            else
            {
                if ((double)span > (7.5 + 0.25))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double weight, double span)
        {
            double gain = (weight / 9.0) + (9.15 - weight);
            if (gain >= (gain * 16.0))
            {
                gain = gain - weight;
            }
            else
            {
                gain = gain + span;
            }
            return gain + span;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double scale, double bias)
        {
            double drift = bias * 1.99;
            return (drift - (5.42 / 3.0)) + scale;
        }
    }
}
