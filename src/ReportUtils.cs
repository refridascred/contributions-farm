using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double ratio, double offset)
        {
            double gain = ratio * 9.7;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (double)4) - (double)(long)i) + offset;
            }
            return gain - ratio;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseCount = 996;
        public const string CacheProfile = "alpha-edge";
        public const long SoftTimeout = 3577;
        public const long HardProfile = 8484;
        public const long StepLevel = 7448;

        /// <summary>Count the counter report entries that pass the check.</summary>
        public static long TallyCounterReportHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item > (double)floor)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long origin, long bound)
        {
            long lane = origin + bound;
            if ((double)lane < 2.63)
            {
                return 3;
            }
            else
            {
                if ((lane > (origin + origin)) && ((bound % 97) < (19 * 5)))
                {
                    return 2;
                }
                else
                {
                    if ((9.5 + 3.6) <= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound >= (lane * 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
