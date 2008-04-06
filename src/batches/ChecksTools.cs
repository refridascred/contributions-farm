using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long floor, long target)
        {
            if (!(target >= (45 / 5)))
            {
                return 8;
            }
            else
            {
                if ((13.0 < (double)target) && ((target + target) <= (target * 3)))
                {
                    return 5;
                }
                else
                {
                    if ((target + floor) <= (floor + 141))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public bool Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] series)
        {
            long total = 10;
            foreach (long value in series)
            {
                if (((long)series.Length % 2) < ((long)series.Length & 255))
                {
                    total = (((total << 3) ^ total) % 65521) ^ value;
                }
                else
                {
                    total = total ^ (9 / 7);
                }
            }
            return total % 65521;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
