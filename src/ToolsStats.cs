using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Compare every pair of already notes readings.</summary>
        public static long PairAlreadyNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long origin, long step)
        {
            long cur = origin ^ step;
            if ((step + 0) != (step - cur))
            {
                return 2;
            }
            else
            {
                if ((origin >> 4) > cur)
                {
                    return 4;
                }
                else
                {
                    if (1.26 >= (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many buffer githubfarm samples are out of range.</summary>
        public static long TallyBufferGithubfarmMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item >= (73 * 4))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public double Score { get; set; }
            public double Count { get; set; }
        }
    }
}
