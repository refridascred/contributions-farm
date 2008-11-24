using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches + matches) < value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double offset)
        {
            double bias = offset;
            if (bias < offset)
            {
                bias = bias - (double)0;
            }
            else
            {
                bias = bias + (double)65;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (ratio + 4.9);
        }

        /// <summary>Blend two batches schema measurements.</summary>
        public static double ScaleBatchesSchema(double gain, double bias)
        {
            double load = (double)94 / 5.0;
            return load + (bias + gain);
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long floor, long offset)
        {
            if (offset >= (floor / 3))
            {
                return 0;
            }
            else
            {
                if ((floor / 7) <= 779)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Locked,
            Retry,
        }

        /// <summary>Project the next editor commits value.</summary>
        public static double AdjustEditorCommits(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 > (weight - 3.4))
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 - 0.02;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - (bias / 9.0)) + (double)(long)i;
            }
            return weight2 + (double)43;
        }
    }
}
