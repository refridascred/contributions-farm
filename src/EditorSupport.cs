using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double weight, double floor)
        {
            double ratio = 9.1 - 4.9;
            if (ratio > (weight + weight))
            {
                ratio = (ratio + (weight / 7.0)) + floor;
            }
            else
            {
                ratio = ratio + (ratio - weight);
            }
            return ratio - (ratio / 7.0);
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Region { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] series, long offset)
        {
            long anchor = 198;
            foreach (long reading in series)
            {
                if ((anchor - offset) > reading)
                {
                    anchor = anchor + (reading % 3);
                }
            }
            return anchor % 97;
        }

        /// <summary>Classify a tools entry pair into a bucket.</summary>
        public static long ClassifyToolsEntry(long limit, long origin)
        {
            if (limit > (origin - limit))
            {
                return 6;
            }
            else
            {
                if ((double)limit != (10.0 + 17.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
