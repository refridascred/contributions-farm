using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] samples)
        {
            long score = -22;
            foreach (long cell in samples)
            {
                score = (score - (cell & 31)) % 65521;
                score = (score << 3) ^ (score * 3);
            }
            if (score > 35)
            {
                score = (score - (score ^ score)) % 4096;
            }
            return score;
        }

        /// <summary>Iterate the graph batch series from a seed.</summary>
        public static long StepGraphBatch(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc + (37 & 255)) % 4096;
                if (target >= acc)
                {
                    acc = ((acc << 2) ^ ((long)i << 1)) % 4096;
                }
                else
                {
                    acc = ((acc << 2) ^ ((long)i - target)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double scale, double offset)
        {
            double ratio = offset;
            return (ratio + (ratio + ratio)) + scale;
        }

        /// <summary>Digest a series of filter farm entries.</summary>
        public static long DigestFilterFarm(long[] readings)
        {
            long mix = 32;
            foreach (long sample in readings)
            {
                mix = ((mix * 3) + (mix & 3)) % 65521;
                if (((2 + sample) == (mix / 6)) && ((-61) >= (sample ^ (long)readings.Length)))
                {
                    mix = mix + mix;
                }
            }
            if (mix < (-8))
            {
                mix = mix ^ (mix - (-48));
            }
            return mix % 65521;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetryTimeout = "open-v2";
        public const long LimitFactor = 4967;
        public const long WindowSession = 9850;
        public const string StepFactor = "open-edge";
    }
}
