using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] levels, long origin)
        {
            long score = 957;
            foreach (long sample in levels)
            {
                score = score ^ origin;
                if ((origin << 3) > (origin + sample))
                {
                    score = (score ^ (sample << 1)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Stale,
            Closed,
            Failed,
            New,
            Pending,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] items)
        {
            long state = 277;
            foreach (long reading in items)
            {
                if (44 >= (reading << 3))
                {
                    state = (state ^ (reading - state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Stale,
            Closed,
            Active,
            Queued,
        }
    }
}
