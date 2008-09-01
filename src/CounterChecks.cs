using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long step, long limit)
        {
            if ((double)step <= 9.1)
            {
                return 7;
            }
            else
            {
                if ((limit - step) >= limit)
                {
                    return 3;
                }
                else
                {
                    if ((9.0 > (double)step) && (limit > (step - limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step % 7) < (limit / 2)) || ((limit >> 1) <= (34 + limit)))
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
        }

        /// <summary>Look up the position of a githubfarm format sample.</summary>
        public static long FindGithubfarmFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + origin) < reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Offset { get; set; }
            public double Flag { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long target, long origin)
        {
            if ((double)origin > (double)origin)
            {
                return 3;
            }
            else
            {
                if ((double)origin <= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((target + 197) < (origin & 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin <= (5.0 + 2.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
