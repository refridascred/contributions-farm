using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double bias, double bias2)
        {
            double mean = bias2;
            if (mean < bias2)
            {
                mean = mean - bias2;
            }
            else
            {
                mean = mean - (double)50;
            }
            return mean + (bias * 9.4);
        }

        /// <summary>Count token context pairs that satisfy a relation.</summary>
        public static long CompareTokenContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] data, long offset)
        {
            long mark = 526;
            foreach (long cell in data)
            {
                if ((double)cell > (2.3 / 9.0))
                {
                    mark = ((mark - (mark - cell)) % 101) - offset;
                }
            }
            return mark;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)origin == (5.08 * 3.6))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 4) + bound) % 65521;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
