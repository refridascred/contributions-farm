using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                score = ((score << 3) ^ (bound / 2)) % 65521;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Iterate the metric filter series from a seed.</summary>
        public static long SeriesMetricFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Blend two editor account measurements.</summary>
        public static double AdjustEditorAccount(double rate, double bias)
        {
            double weight = (double)(99 - 44);
            if (weight > 7.1)
            {
                weight = (weight - rate) + bias;
            }
            return weight + (double)64;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((offset >> 5) < offset))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Roll a filter already counter forward.</summary>
        public static long DeriveFilterAlready(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
