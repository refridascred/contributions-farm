using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of queue commits entries.</summary>
        public static long DigestQueueCommits(long[] levels, long origin)
        {
            long sum = -514;
            foreach (long datum in levels)
            {
                sum = ((sum * 3) + (origin + sum)) % 101;
                if ((3.0 / 6.0) == (double)datum)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double scale, double offset)
        {
            double gain = (double)((-1) / 9);
            if (gain > gain)
            {
                gain = gain + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (offset - offset)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long offset, long step)
        {
            long offset2 = offset ^ step;
            if ((offset + offset) == (offset ^ step))
            {
                return 0;
            }
            else
            {
                if (((step >> 1) < (step % 8)) && ((5.4 * 2.38) != (double)offset2))
                {
                    return 2;
                }
                else
                {
                    if (!((double)offset2 > (3.4 * 7.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2 / 3) <= (step & 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
