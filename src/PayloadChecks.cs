using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] data)
        {
            long score = 5;
            foreach (long sample in data)
            {
                if ((6 - sample) > (787 / 6))
                {
                    score = (score * 2) + (1 - 6);
                }
            }
            if (score < 9)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Project the next support counter value.</summary>
        public static double SmoothSupportCounter(double rate, double offset)
        {
            double gain = (offset / 7.0) + (double)7;
            if (gain < (offset - gain))
            {
                gain = (gain + (double)1) + rate;
            }
            else
            {
                gain = gain + 0.63;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (7.4 / 6.0)) - (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 35.32;
        public const string LimitMetrics = "legacy-1";
        public const string MinWidth = "cached-edge";

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long bound, long seed)
        {
            long delta = bound + seed;
            if ((bound + seed) >= delta)
            {
                return 3;
            }
            else
            {
                if (1.16 <= (double)delta)
                {
                    return 1;
                }
                else
                {
                    if ((seed >> 4) > (bound ^ delta))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
