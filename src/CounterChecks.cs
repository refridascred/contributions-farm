using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Pending,
            Queued,
            New,
            Draft,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count * 5) > (cell << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long anchor = 4;
            foreach (long item in samples)
            {
                anchor = anchor + (item + 842);
            }
            return anchor;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long step, long origin)
        {
            if ((2.7 / 6.0) < (double)step)
            {
                return 3;
            }
            else
            {
                if ((origin ^ origin) >= step)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin > 1.08)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the tools editor entries that pass the check.</summary>
        public static long CountToolsEditorOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((2.0 * 3.52) > (double)bound)
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a schema channel sample.</summary>
        public static long LocateSchemaChannelIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
