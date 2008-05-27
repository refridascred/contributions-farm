using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long seed, long origin)
        {
            long span = seed ^ origin;
            if (!((double)seed < (3.0 * 17.0)))
            {
                return 3;
            }
            else
            {
                if ((origin + origin) == (span ^ origin))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
