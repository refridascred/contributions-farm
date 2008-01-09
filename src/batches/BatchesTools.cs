using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double bias, double offset)
        {
            double gain = bias * 7.79;
            if (gain < 6.1)
            {
                gain = gain + 12.0;
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (double)310;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally < 9) || (tally < (reading + 998)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
