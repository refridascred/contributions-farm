using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long offset, long step)
        {
            if (((step / 4) < offset) && (offset <= (step + step)))
            {
                return 3;
            }
            else
            {
                if ((offset - (-974)) <= step)
                {
                    return 0;
                }
                else
                {
                    if (offset < (offset * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((0.7 * 11.0) >= (double)count)
                {
                    count = (count + 2) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 9667;
        public const double SoftScore = 20.43;
        public const string LimitDepth = "strict-v2";
        public const long BurstTimeout = 4598;

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
