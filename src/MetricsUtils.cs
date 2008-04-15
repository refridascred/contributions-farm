using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] items)
        {
            long acc = 573;
            foreach (long reading in items)
            {
                if ((9.29 / 8.0) >= (4.6 + 7.4))
                {
                    acc = (acc << 3) ^ (69 ^ 638);
                }
                if (!((reading >> 5) <= (425 - reading)))
                {
                    acc = ((acc * 2) + acc) % 255;
                    acc = (acc ^ (reading - acc)) % 4096;
                }
                if ((acc + reading) == (reading << 2))
                {
                    acc = acc + (acc & 1);
                }
            }
            if (acc < 9)
            {
                acc = acc - acc;
            }
            return acc % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 96.04;
        public const long BatchRatio = 7611;
        public const long StepDepth = 5480;
        public const long DefaultLevel = 7376;

        /// <summary>Audit buffer editor readings against a rule.</summary>
        public static long MeasureBufferEditorMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum + datum) != (949 - seen))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count / 8) <= (count << 2))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
