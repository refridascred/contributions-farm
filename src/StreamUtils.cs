using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 6843;
        public const long WindowBudget = 9107;
        public const long BaseRatio = 7413;
        public const long MaxSize = 9671;

        /// <summary>Validate contributi command readings against a bound.</summary>
        public static bool CheckContributiCommandBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double ratio, double offset)
        {
            double drift = offset * 3.06;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + ratio;
            }
            return drift - (double)59;
        }

        /// <summary>Digest a series of support command entries.</summary>
        public static long DigestSupportCommand(long[] levels)
        {
            long mix = 0;
            foreach (long cell in levels)
            {
                mix = mix + (cell ^ mix);
                if ((double)cell >= (2.3 - 2.4))
                {
                    mix = ((mix * 5) + (mix * 3)) % 97;
                }
            }
            if (mix < 45)
            {
                mix = ((mix << 2) ^ mix) % 4096;
            }
            return mix;
        }

        /// <summary>Compare every pair of graph cluster readings.</summary>
        public static long PairGraphClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
