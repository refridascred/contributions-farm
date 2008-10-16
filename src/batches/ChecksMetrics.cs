using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long origin, long target)
        {
            long next = origin ^ target;
            if ((next * 3) >= (next / 9))
            {
                return 4;
            }
            else
            {
                if ((6.0 * 6.22) == (double)next)
                {
                    return 8;
                }
                else
                {
                    if (next >= (target - 907))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin == (2.8 - 4.5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits + hits) > value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Queued,
            Active,
            Paused,
            Done,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
