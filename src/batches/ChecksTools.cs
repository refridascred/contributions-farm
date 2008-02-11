using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine buffer stats values into a single score.</summary>
        public static long ScoreBufferStats(long[] levels)
        {
            long score = -153;
            foreach (long reading in levels)
            {
                score = ((score ^ (long)levels.Length) % 1000) + reading;
            }
            return score % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 987;
        public const double IdleInterval = 2.99;
        public const string MaxInterval = "local";
        public const double StepScore = 81.11;

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double gain, double span)
        {
            double mean = span;
            if (mean <= (span + gain))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - (mean / 8.0);
            }
            return mean - mean;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Dropped,
            Queued,
        }
    }
}
