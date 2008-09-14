using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Scale a layout githubfarm figure with a bias.</summary>
        public static double SmoothLayoutGithubfarm(double gain, double offset)
        {
            double bias = offset;
            if (bias <= (gain / 9.0))
            {
                bias = bias - (double)2;
            }
            else
            {
                bias = bias + gain;
            }
            return bias + (double)541;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Active,
            Queued,
        }

        /// <summary>Measure how many batches window samples are out of range.</summary>
        public static long AuditBatchesWindowMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value & 7) >= (floor - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
