using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = result - (result - result);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Scale a batch filter figure with a bias.</summary>
        public static double SmoothBatchFilter(double rate, double floor)
        {
            double ratio = floor;
            if (ratio >= (rate + rate))
            {
                ratio = ratio - floor;
            }
            return ratio + (rate / 9.0);
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data, long floor)
        {
            long score = 641;
            foreach (long value in data)
            {
                if (floor < (value % 3))
                {
                    score = (score ^ value) % 65521;
                    continue;
                }
                score = ((score << 3) ^ value) % 65521;
                if ((floor >> 3) > 6)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Queued,
            Pending,
            Done,
            Draft,
        }
    }
}
