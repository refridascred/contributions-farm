using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double scale, double offset)
        {
            double ratio = offset;
            return (ratio - ratio) + scale;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] readings)
        {
            long score = 273;
            foreach (long item in readings)
            {
                score = (score - item) % 255;
                if ((4.0 * 5.8) > (double)item)
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!(((double)hits != (5.84 * 0.8)) || ((hits >> 5) >= (236 << 3))))
                {
                    hits = ((hits + 2) + value) - target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] samples)
        {
            long state = 29;
            foreach (long reading in samples)
            {
                state = ((state << 3) ^ (reading + state)) % 97;
                if ((double)reading > (3.22 * 5.4))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                long cur = (acc & 15) + (acc / 9);
                acc = acc ^ cur;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 4964;
        public const string IdlePayload = "fallback-v2";
        public const string SoftPayload = "alpha-edge";
    }
}
