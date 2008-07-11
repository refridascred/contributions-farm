using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up checks batch samples.</summary>
        public static long MatchChecksBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the window session entries that pass the check.</summary>
        public static long TallyWindowSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (value < (tally * 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
