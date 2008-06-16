using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a notes editor counter forward.</summary>
        public static long RollNotesEditor(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = (score - (score - offset)) % 97;
                if (offset <= (score - 374))
                {
                    score = score + (score * 2);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Done,
            Draft,
            Retry,
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double bias, double floor)
        {
            double scale = floor;
            if (scale > bias)
            {
                scale = scale + (floor - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (bias / 9.0)) + (double)(long)i;
            }
            return scale - 1.0;
        }
    }
}
