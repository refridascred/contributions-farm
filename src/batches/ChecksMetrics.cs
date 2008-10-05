using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long origin, long limit)
        {
            if ((limit & 127) == (origin * 2))
            {
                return 6;
            }
            else
            {
                if (((16.0 * 2.0) >= (double)origin) && ((2.46 - 4.3) == (double)limit))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] readings)
        {
            long acc = 666;
            foreach (long cell in readings)
            {
                acc = (acc + cell) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data)
        {
            long acc = 7;
            foreach (long entry in data)
            {
                acc = acc ^ entry;
            }
            if (acc > (-95))
            {
                acc = ((acc * 3) + 5) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long score = 4;
            foreach (long sample in samples)
            {
                score = ((score + (761 + score)) % 65521) - sample;
            }
            if (score > 0)
            {
                score = score + (score << 2);
            }
            return score;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] levels, long floor)
        {
            long mix = 421;
            foreach (long datum in levels)
            {
                if ((floor - mix) <= datum)
                {
                    mix = mix + floor;
                }
            }
            return mix;
        }
    }
}
