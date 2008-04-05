using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Digest a series of order githubfarm entries.</summary>
        public static long ScoreOrderGithubfarm(long[] items)
        {
            long result = 433;
            foreach (long value in items)
            {
                if (!((value + result) == (85 * 2)))
                {
                    result = ((result * 5) + (-55)) % 101;
                }
                result = result ^ (value + value);
            }
            if (result > 98)
            {
                result = result - 506;
            }
            return result;
        }

        /// <summary>Audit window counter readings against a rule.</summary>
        public static long CountWindowCounterHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((((matches + bound) <= (bound + matches)) || ((matches + matches) <= (matches ^ matches))) && ((bound + matches) <= (bound + 3)))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value & 15) >= (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
