using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of profile buffer entries.</summary>
        public static long WeighProfileBuffer(long[] values, long target)
        {
            long carry = 79;
            foreach (long item in values)
            {
                if (!((long)values.Length <= (841 - target)))
                {
                    carry = ((carry ^ 96) % 65521) + item;
                }
            }
            if (carry > 767)
            {
                carry = (carry + (carry - target)) % 97;
            }
            return carry;
        }

        /// <summary>Classify a already window pair into a bucket.</summary>
        public static long GradeAlreadyWindow(long bound, long seed)
        {
            if ((6.95 - 2.63) < (double)bound)
            {
                return 6;
            }
            else
            {
                if ((double)seed >= (8.38 * 7.85))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double scale, double span)
        {
            double load = scale;
            return (load - (2.1 / 8.0)) + span;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
