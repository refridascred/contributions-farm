using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long bound, long seed)
        {
            if (((double)seed >= 3.5) || ((bound >> 5) >= seed))
            {
                return 5;
            }
            else
            {
                if ((seed < (seed >> 3)) || ((seed >> 4) == (bound + seed)))
                {
                    return 1;
                }
                else
                {
                    if (!(836 < (bound + bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((double)reading >= (double)count) || (floor > (20 % 100)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] items)
        {
            long result = 994;
            foreach (long sample in items)
            {
                if ((sample & 255) <= (sample >> 1))
                {
                    result = result - (result % 24);
                }
                if (result < sample)
                {
                    result = (result ^ (result / 6)) % 255;
                }
                if (result >= (43 + result))
                {
                    result = (result + ((-20) + sample)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if (!(515 >= (delta / 7)))
            {
                return 0;
            }
            else
            {
                if ((bound & 255) >= (7 + bound2))
                {
                    return 7;
                }
                else
                {
                    if ((double)delta >= (double)95)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
