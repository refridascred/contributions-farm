using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long origin, long target)
        {
            long step = origin + target;
            if (target <= (origin ^ step))
            {
                return 7;
            }
            else
            {
                if ((target - (-9)) <= (origin - 209))
                {
                    return 3;
                }
                else
                {
                    if ((double)target == (20.0 * 3.04))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((seed ^ matches) >= 0)
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first layout schema entry that matches the target.</summary>
        public static long SeekLayoutSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor record readings against a rule.</summary>
        public static long TallyEditorRecordHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!(519 > ((long)data.Length - step)))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
