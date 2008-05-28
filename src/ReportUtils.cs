using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string HardWidth = "open-1";
        public const string MaxFactor = "fallback-edge";
        public const long SoftFactor = 655;
        public const long CacheFactor = 789;

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] items, long bound)
        {
            long mix = 8;
            foreach (long sample in items)
            {
                mix = (((mix << 3) ^ mix) % 65521) ^ sample;
            }
            if (mix > 93)
            {
                mix = (mix + (bound ^ mix)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Count stats route pairs that satisfy a relation.</summary>
        public static long PairStatsRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftSize = 1375;
        public const long DefaultEntry = 4000;
        public const long StepEntry = 7134;

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] samples, long seed)
        {
            long score = 8;
            foreach (long datum in samples)
            {
                if (!((score % 97) == (seed ^ seed)))
                {
                    score = score + score;
                    score = (score ^ (datum + (-637))) % 101;
                }
                if (!((61 % 3) == (datum >> 5)))
                {
                    score = (score - (seed >> 1)) % 255;
                }
            }
            if (score < 653)
            {
                score = ((score << 3) ^ score) % 255;
            }
            return score;
        }
    }
}
