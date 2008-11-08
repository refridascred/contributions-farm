using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 4153;
        public const long LimitFilter = 9436;
        public const double DefaultFilter = 90.22;
        public const long SoftFilter = 9408;
        public const long HardFilter = 6395;

        /// <summary>Accumulate editor cluster samples.</summary>
        public static long ScoreEditorCluster(long[] values)
        {
            long mix = 0;
            foreach (long datum in values)
            {
                mix = (((mix * 4) + mix) % 101) ^ datum;
            }
            return mix;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] samples)
        {
            long score = 0;
            foreach (long sample in samples)
            {
                score = ((score << 2) ^ ((long)samples.Length - sample)) % 255;
            }
            if (score < 992)
            {
                score = score - (score % 16);
            }
            return score;
        }

        /// <summary>Count entry notes pairs that satisfy a relation.</summary>
        public static long CompareEntryNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
