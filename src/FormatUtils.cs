using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = score ^ (long)i;
                score = (score - (seed % 5)) % 1000;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Dropped,
            Failed,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long target, long offset)
        {
            long step = target ^ offset;
            if ((target ^ 99) != (step + 52))
            {
                return 2;
            }
            else
            {
                if (((5.0 - 5.0) <= (double)offset) || ((target & 1) <= (step - target)))
                {
                    return 6;
                }
                else
                {
                    if ((target + target) != (step + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step >> 1) <= target)
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

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first commits batches entry that matches the target.</summary>
        public static long LookupCommitsBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a buffer commits reading.</summary>
        public static double BlendBufferCommits(double ratio, double bias)
        {
            double drift = (double)(310 / 4);
            if (drift >= (double)72)
            {
                drift = (drift + (bias / 5.0)) - ratio;
            }
            else
            {
                drift = drift + (double)0;
            }
            return drift - 7.07;
        }
    }
}
