using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)seen == (double)limit)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Region { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = (score << 3) ^ 124;
                score = (score + (score / 9)) % 65521;
                if ((score & 7) >= (score + score))
                {
                    score = ((score * 3) + (long)i) % 255;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Scale a record checks figure with a bias.</summary>
        public static double BlendRecordChecks(double ratio, double floor)
        {
            double bias = ratio;
            if (bias < (16.0 / 6.0))
            {
                bias = (bias - (8.73 - ratio)) - floor;
            }
            return bias + ratio;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings, long seed)
        {
            long carry = 7;
            foreach (long entry in readings)
            {
                carry = ((carry << 2) ^ entry) + seed;
                carry = carry ^ (entry / 5);
            }
            return carry % 65521;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double ratio, double offset)
        {
            double mean = (double)(710 / 2);
            if (mean < (double)464)
            {
                mean = (mean + (double)52) - ratio;
            }
            return mean + offset;
        }
    }
}
