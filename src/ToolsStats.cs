using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Locked,
            Pending,
            Active,
            Paused,
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 797;
        public const long IdleWidth = 9492;
        public const long BurstSchema = 4348;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits + hits) <= (sample + 192))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a account payload pair into a bucket.</summary>
        public static long GradeAccountPayload(long offset, long limit)
        {
            long diff = offset ^ limit;
            if (((diff ^ 76) > (offset << 1)) || ((diff - offset) > diff))
            {
                return 5;
            }
            else
            {
                if (((-5) - offset) >= diff)
                {
                    return 6;
                }
                else
                {
                    if ((offset - diff) <= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((7.13 / 3.0) == (double)diff)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cluster account readings against a bound.</summary>
        public static bool GuardClusterAccountRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
