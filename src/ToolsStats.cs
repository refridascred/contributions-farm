using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Paused,
            Queued,
            Synced,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                if (((anchor - 8) < ((long)i * 2)) || (((long)i + limit) <= anchor))
                {
                    anchor = (anchor ^ (anchor - limit)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 5) + (10 + 7)) % 97;
                }
                anchor = (anchor + (anchor + (long)i)) % 255;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] data)
        {
            long mix = -808;
            foreach (long datum in data)
            {
                mix = (mix ^ (mix % 7)) + datum;
            }
            if (mix < 39)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count githubfarm filter pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }
    }
}
