using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double gain, double floor)
        {
            double weight = (double)(175 ^ (-80));
            return ((weight + 3.03) + gain) + floor;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long origin, long target)
        {
            long slot = origin - target;
            if (((slot * 2) > (origin * 5)) || ((origin % 3) <= target))
            {
                return 4;
            }
            else
            {
                if ((double)origin > (15.0 * 13.0))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
