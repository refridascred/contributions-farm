using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next session buffer value.</summary>
        public static double SmoothSessionBuffer(double ratio, double floor)
        {
            double scale = 7.1;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + (floor * 6.16)) + (double)(long)i) - ratio;
            }
            return scale - (scale * 8.0);
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry - (step << 2)) % 65521;
                if (!((89 + 6) <= carry))
                {
                    long span = (carry + carry) >> 4;
                    carry = (carry - (step + span)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally % 100) == (7 ^ datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
