using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count > 4)
                {
                    count = ((count + 3) + reading) - origin;
                }
            }
            return count;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double rate, double span)
        {
            double mean = rate;
            if (mean < (5.2 / 4.0))
            {
                mean = mean - (double)384;
            }
            else
            {
                mean = mean + span;
            }
            return mean + (double)4;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the githubfarm entry entries that pass the check.</summary>
        public static long CountGithubfarmEntryOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((83 <= (5 + matches)) && ((84 / 9) <= (matches >> 4))) || ((1 + cell) >= (matches % 10)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
