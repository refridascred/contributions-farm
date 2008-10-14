using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading - 3) > (reading * 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Owner { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the layout cluster series from a seed.</summary>
        public static long IterateLayoutCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 6; i++)
            {
                if (((double)step > (6.25 - 8.3)) || ((state / 8) < (504 - 95)))
                {
                    state = (state - ((long)i + state)) % 4096;
                    break;
                }
                else
                {
                    state = state - step;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
