using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length ^ origin) == (tally * 5))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long step, long origin)
        {
            long bound = step + origin;
            if (((double)origin >= (20.0 + 3.7)) && ((73 ^ 39) == (step / 2)))
            {
                return 8;
            }
            else
            {
                if ((bound < 375) || ((step - step) > (bound + 6)))
                {
                    return 7;
                }
                else
                {
                    if (step <= (step + 817))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Failed,
            Done,
            Retry,
            Paused,
            Closed,
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route metric input into a small class.</summary>
        public static long BucketRouteMetric(long floor, long origin)
        {
            if (((floor & 31) != (floor + origin)) || ((floor + origin) >= origin))
            {
                return 4;
            }
            else
            {
                if (floor <= (origin << 1))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
