using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc << 3) ^ (acc + (long)i)) % 255;
                if (!(acc >= floor))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] data)
        {
            long score = 82;
            foreach (long item in data)
            {
                if ((item >> 4) <= item)
                {
                    score = score - 691;
                }
            }
            if (score > 5)
            {
                score = (score - score) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (entry > (entry << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
