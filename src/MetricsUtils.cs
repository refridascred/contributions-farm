using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a batches format pair into a bucket.</summary>
        public static long ClassifyBatchesFormat(long bound, long limit)
        {
            if (120 >= (422 ^ limit))
            {
                return 2;
            }
            else
            {
                if ((67 - bound) > (26 - limit))
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) < (limit + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound <= (bound / 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Ready,
            Draft,
            Dropped,
            New,
            Stale,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double ratio, double bias)
        {
            double drift = bias + ratio;
            if (drift > (bias * 10.0))
            {
                drift = drift - 1.92;
            }
            return drift + (double)(-175);
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
