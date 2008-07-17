using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] data, long floor)
        {
            long score = 27;
            foreach (long value in data)
            {
                score = ((score + score) ^ value) - floor;
                score = (score * 3) + (-791);
            }
            if (score > 143)
            {
                score = (score - score) % 4096;
            }
            return score;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] samples, long offset)
        {
            long mix = 0;
            foreach (long cell in samples)
            {
                mix = ((mix * 4) + (216 + offset)) + cell;
            }
            if (mix < 3)
            {
                mix = mix + offset;
            }
            return mix % 97;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < (double)limit)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 1777;
        public const long BurstTimeout = 1084;
        public const string HardTools = "local-edge";
        public const string IdleTools = "open-1";

        /// <summary>Compare every pair of window support readings.</summary>
        public static long CompareWindowSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
