using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the profile format series from a seed.</summary>
        public static long IterateProfileFormat(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                total = total ^ total;
                total = (total << 2) ^ (target / 4);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of githubfarm report readings.</summary>
        public static long PairGithubfarmReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Label { get; set; }
            public bool Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry + tally) <= (entry - step))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
