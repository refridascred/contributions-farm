using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many layout tools samples are out of range.</summary>
        public static long TallyLayoutToolsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (373 <= (seen << 2))
                {
                    seen = (seen + 2) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double bias, double bias2)
        {
            double weight = (double)680 * 7.8;
            if (weight >= (double)127)
            {
                weight = (weight + (bias * 6.0)) + bias2;
            }
            else
            {
                weight = weight + (double)(-89);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (weight - 3.7)) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (matches >= (value + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
