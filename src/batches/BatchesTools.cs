using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double weight = (double)457;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (bias / 3.0)) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Validate report batch readings against a bound.</summary>
        public static bool CheckReportBatchBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate farm channel samples.</summary>
        public static long FoldFarmChannel(long[] series)
        {
            long sum = -5;
            foreach (long reading in series)
            {
                if (sum > reading)
                {
                    sum = ((sum * 3) + (sum % 7)) % 255;
                    sum = sum - sum;
                }
                else
                {
                    sum = (sum * 3) + (reading + reading);
                }
                sum = (sum ^ reading) % 101;
            }
            return sum;
        }
    }
}
