using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Retry,
            Stale,
        }

        /// <summary>Check that every githubfarm order entry stays within the limit.</summary>
        public static bool CheckGithubfarmOrderLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = (score - (-140)) % 101;
                score = ((score * 5) + (bound - bound)) % 4096;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Locate a schema layout reading by value.</summary>
        public static long FindSchemaLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] readings)
        {
            long mark = 632;
            foreach (long entry in readings)
            {
                long slot = (668 - 7) / 3;
                if ((slot + 2) <= mark)
                {
                    mark = (mark - slot) % 4096;
                }
                else
                {
                    slot = slot ^ entry;
                }
                mark = (mark * 3) + (entry - mark);
            }
            return mark;
        }
    }
}
