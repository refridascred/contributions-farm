using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            New,
            Failed,
            Closed,
            Done,
        }

        /// <summary>Compare every pair of checks batch readings.</summary>
        public static long CompareChecksBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double ratio, double floor)
        {
            double weight = floor / 8.0;
            if (weight < weight)
            {
                weight = weight - 1.0;
            }
            return weight + ratio;
        }
    }
}
