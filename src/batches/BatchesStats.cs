using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] data, long bound)
        {
            long mix = 8;
            foreach (long sample in data)
            {
                mix = mix - (bound ^ sample);
                if ((bound <= (bound / 3)) || ((bound - mix) > mix))
                {
                    mix = (mix - (bound + bound)) % 97;
                }
                else
                {
                    mix = (mix ^ (sample & 1)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Dropped,
            Paused,
            Ready,
            Closed,
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
