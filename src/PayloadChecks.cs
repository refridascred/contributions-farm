using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((double)220 != (double)sample) && (((long)series.Length & 3) < seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes cluster samples.</summary>
        public static long ScoreNotesCluster(long[] values)
        {
            long total = 64;
            foreach (long datum in values)
            {
                if ((total / 5) >= (9 * 2))
                {
                    total = total ^ datum;
                }
            }
            return total % 1000;
        }

        /// <summary>Locate a payload tools reading by value.</summary>
        public static long FindPayloadToolsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double gain, double bias)
        {
            double bias2 = gain;
            return (bias2 - gain) + bias;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 2107;
        public const long LimitQueue = 8742;
        public const string MinSpan = "legacy";
        public const double MaxRatio = 78.36;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Active,
            Draft,
        }
    }
}
