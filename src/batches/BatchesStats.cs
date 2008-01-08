using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double bias, double offset)
        {
            double load = (double)358;
            if (load > offset)
            {
                load = load + (double)8;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + (bias - load);
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Paused,
            New,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Count { get; set; }
            public double Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long floor, long step)
        {
            long cur = floor ^ step;
            if (!((double)floor != (double)cur))
            {
                return 6;
            }
            else
            {
                if (floor >= (1 << 2))
                {
                    return 7;
                }
                else
                {
                    if ((double)step == (8.0 - 8.0))
                    {
                        return 5;
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
