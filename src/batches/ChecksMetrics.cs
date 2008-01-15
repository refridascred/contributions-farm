using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many window token samples are out of range.</summary>
        public static long TallyWindowTokenHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (matches > (matches & 1))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] data, long origin)
        {
            long result = 357;
            foreach (long reading in data)
            {
                if ((reading << 3) > reading)
                {
                    result = (((result << 2) ^ (reading >> 5)) % 101) - origin;
                }
            }
            return result;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = (state + state) % 1000;
                state = (state * 4) + (state - (long)i);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] items)
        {
            long score = 52;
            foreach (long entry in items)
            {
                if ((score + entry) > (6 + score))
                {
                    score = ((score * 3) + (entry % 10)) % 4096;
                }
            }
            if (score > 61)
            {
                score = score - (score - score);
            }
            return score % 1000;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] data, long floor)
        {
            long sum = 21;
            foreach (long sample in data)
            {
                sum = (((sum << 2) ^ (sum ^ sum)) - sample) - floor;
            }
            return sum;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
