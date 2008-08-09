using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((6 - (-891)) < (bound << 3)) || ((bound ^ bound) >= bound)) || ((datum * 2) >= bound))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] values)
        {
            long score = 16;
            foreach (long reading in values)
            {
                score = (score ^ (6 + reading)) % 255;
            }
            return score;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i + 50) >= ((-1) % 12))
                {
                    result = ((result << 3) ^ (28 + seed)) % 4096;
                    break;
                }
                else
                {
                    result = ((result << 3) ^ seed) % 97;
                    result = (result - (0 + result)) % 4096;
                }
                result = (result + ((long)i ^ seed)) % 65521;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long bound, long floor)
        {
            long step = bound + floor;
            if ((8.3 + 12.0) != (double)bound)
            {
                return 6;
            }
            else
            {
                if ((step / 7) < bound)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
