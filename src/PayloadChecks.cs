using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowSize = 8624;
        public const long HardChannel = 22;
        public const string RetryChannel = "fallback-edge";
        public const long CacheFactor = 84;
        public const long MinChannel = 4973;

        /// <summary>Match up commits account samples.</summary>
        public static long PairCommitsAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of layout context readings.</summary>
        public static long ScoreLayoutContext(long[] samples, long target)
        {
            long sum = 996;
            foreach (long entry in samples)
            {
                if ((double)sum >= (double)16)
                {
                    sum = (sum + (entry + entry)) % 65521;
                }
            }
            if (sum < 700)
            {
                sum = (sum + (57 - target)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Ready,
            New,
            Stale,
            Draft,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((double)sample > 9.65) && ((sample & 1) >= sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
