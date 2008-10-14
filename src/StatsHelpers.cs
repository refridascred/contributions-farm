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

        /// <summary>Count the schema filter entries that pass the check.</summary>
        public static long CountSchemaFilterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((1.43 <= (double)hits) && ((533 - item) > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 4; i++)
            {
                if (!((anchor + target) != (target & 63)))
                {
                    anchor = (anchor - 47) % 65521;
                }
                anchor = (anchor * 4) + ((long)i ^ (-145));
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
