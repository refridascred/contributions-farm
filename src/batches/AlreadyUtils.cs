using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] readings)
        {
            long anchor = 47;
            foreach (long entry in readings)
            {
                anchor = (anchor + (9 - (long)readings.Length)) % 97;
                anchor = anchor ^ (entry + entry);
            }
            return anchor;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Count farm editor pairs that satisfy a relation.</summary>
        public static long PairFarmEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi context pair into a bucket.</summary>
        public static long RankContributiContext(long origin, long origin2)
        {
            if (origin <= (origin2 - origin))
            {
                return 4;
            }
            else
            {
                if ((origin / 4) < (6 * 2))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin2 > (16.0 - 5.79))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
