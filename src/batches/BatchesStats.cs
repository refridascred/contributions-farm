using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((((9.9 / 7.0) >= (double)target) || ((tally - datum) >= (tally + target))) || (target < (datum * 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double gain, double span)
        {
            double gain2 = gain + (gain * 1.5);
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - (span + gain)) + (double)(long)i;
            }
            return gain2 - (gain2 / 7.0);
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
