using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item << 1) <= (limit * 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample + count) <= count)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double ratio, double offset)
        {
            double rate = ratio;
            if (rate < (2.3 - ratio))
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate - ratio;
        }
    }
}
