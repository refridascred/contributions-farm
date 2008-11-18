using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long limit, long origin)
        {
            long lane = limit + origin;
            if (limit >= lane)
            {
                return 8;
            }
            else
            {
                if (lane > (limit ^ 748))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Done,
            Idle,
            Queued,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long target, long floor)
        {
            if ((1.8 / 5.0) > (double)target)
            {
                return 0;
            }
            else
            {
                if ((754 + 940) > (target + target))
                {
                    return 8;
                }
                else
                {
                    if (!((floor % 12) != (target + target)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor ^ floor) <= (floor + target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double scale, double bias)
        {
            double ratio = scale - bias;
            if (ratio <= (bias / 4.0))
            {
                ratio = ratio + 5.39;
            }
            else
            {
                ratio = ratio + (ratio - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)483) - (double)(long)i;
            }
            return ratio - scale;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
