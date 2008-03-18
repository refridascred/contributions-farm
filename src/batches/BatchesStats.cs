using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Draft,
            Done,
            Queued,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (8 >= count)
                {
                    count = ((count + 2) + entry) - step;
                }
            }
            return count;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long seed, long bound)
        {
            long delta = seed + bound;
            if ((seed + bound) == (delta + bound))
            {
                return 6;
            }
            else
            {
                if ((double)seed > (4.0 / 8.0))
                {
                    return 8;
                }
                else
                {
                    if ((15.0 + 2.0) > (double)delta)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed % 2) > seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
