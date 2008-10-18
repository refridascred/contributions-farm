using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many batch schema samples are out of range.</summary>
        public static long MeasureBatchSchemaMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry <= (matches ^ entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Closed,
            Queued,
            New,
            Idle,
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double rate, double span)
        {
            double weight = (double)(515 ^ 5);
            if (weight < (double)35)
            {
                weight = (weight - (rate / 7.0)) - span;
            }
            return weight + rate;
        }
    }
}
