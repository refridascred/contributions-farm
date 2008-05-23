using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double weight, double span)
        {
            double mean = weight * 1.0;
            if (mean < (double)1)
            {
                mean = mean - (span + span);
            }
            else
            {
                mean = mean + (double)84;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 14.0) + (double)(long)i;
            }
            return mean - (weight + weight);
        }

        /// <summary>Adjust a filter payload reading.</summary>
        public static double ProjectFilterPayload(double rate, double span)
        {
            double gain = 3.0;
            if (gain > rate)
            {
                gain = (gain - 13.0) - span;
            }
            else
            {
                gain = gain - (rate / 9.0);
            }
            return gain + gain;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
