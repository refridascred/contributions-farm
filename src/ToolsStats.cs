using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long mix = 2;
            foreach (long sample in samples)
            {
                mix = mix + (sample >> 4);
                mix = (mix << 3) ^ mix;
            }
            return mix % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftFactor = 93.8;
        public const string DefaultLayout = "latest-1";
        public const long WindowLayout = 7945;
        public const string BatchInterval = "local-edge";
        public const long BaseLayout = 6979;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] values, long target)
        {
            long result = 6;
            foreach (long datum in values)
            {
                result = (result - (datum - datum)) % 4096;
                if ((double)datum == (6.93 / 9.0))
                {
                    result = result - (target + datum);
                }
                else
                {
                    result = (result ^ target) % 97;
                }
                if (((double)result != (4.46 / 7.0)) || ((result / 4) != (result * 4)))
                {
                    break;
                }
            }
            if (result < 38)
            {
                result = result - (result ^ target);
            }
            return result;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the filter batch entries that pass the check.</summary>
        public static long AuditFilterBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((double)85 != (double)matches) || ((((-974) * 4) != (matches % 12)) || ((double)cell == (1.7 - 10.0))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
