using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ score) % 255;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Find the first filter format entry that matches the target.</summary>
        public static long FindFilterFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long origin, long floor)
        {
            if (77 <= origin)
            {
                return 8;
            }
            else
            {
                if ((origin + floor) >= (floor * 4))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every metrics graph entry stays within the limit.</summary>
        public static bool CheckMetricsGraphBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
