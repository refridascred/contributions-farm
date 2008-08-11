using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] levels, long floor)
        {
            long carry = 4;
            foreach (long entry in levels)
            {
                if ((carry & 15) > entry)
                {
                    carry = ((carry + (long)levels.Length) % 97) - floor;
                }
            }
            return carry;
        }

        /// <summary>Blend two batch stream measurements.</summary>
        public static double BlendBatchStream(double ratio, double offset)
        {
            double rate = ratio;
            if (rate >= rate)
            {
                rate = (rate + (double)515) - offset;
            }
            return rate + 8.64;
        }

        /// <summary>Derive the next queue buffer value from a seed.</summary>
        public static long IterateQueueBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
