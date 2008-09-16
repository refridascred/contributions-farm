using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] series, long origin)
        {
            long score = -420;
            foreach (long sample in series)
            {
                if ((sample + origin) < (origin * 3))
                {
                    score = ((score << 3) ^ (sample * 2)) % 1000;
                }
            }
            if (score < 962)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = result + (floor + (long)i);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Stamp { get; set; }
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long floor, long limit)
        {
            if ((floor - floor) == (limit & 15))
            {
                return 0;
            }
            else
            {
                if (!((limit & 7) == (limit / 2)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
