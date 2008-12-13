using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] levels)
        {
            long acc = 6;
            foreach (long item in levels)
            {
                if ((item > (item + acc)) && ((item / 4) < (item & 15)))
                {
                    acc = ((acc << 3) ^ (acc / 8)) % 97;
                }
                if ((acc + item) >= (6 + acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Find the first counter metrics entry that matches the target.</summary>
        public static long LocateCounterMetricsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long origin, long bound)
        {
            if (bound < (bound ^ origin))
            {
                return 8;
            }
            else
            {
                if ((origin * 3) > 0)
                {
                    return 4;
                }
                else
                {
                    if ((origin + bound) > (origin << 1))
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

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
