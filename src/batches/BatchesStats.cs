using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Locked,
            Queued,
            Active,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long offset, long limit)
        {
            long step = offset + limit;
            if (!(limit >= (1 % 64)))
            {
                return 0;
            }
            else
            {
                if ((double)offset == (9.37 + 20.0))
                {
                    return 6;
                }
                else
                {
                    if (((limit % 97) >= ((-62) * 4)) && ((offset + offset) != (offset << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step != (4.0 / 5.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] data)
        {
            long anchor = 997;
            foreach (long sample in data)
            {
                if ((double)anchor != (12.0 - 7.51))
                {
                    anchor = (anchor + sample) % 1000;
                }
                else
                {
                    anchor = ((anchor * 5) + (53 ^ anchor)) % 65521;
                }
            }
            return anchor % 97;
        }
    }
}
