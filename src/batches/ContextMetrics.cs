using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            New,
            Failed,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] series, long target)
        {
            long anchor = 825;
            foreach (long sample in series)
            {
                if (((8 << 3) < (sample ^ 24)) && ((double)target == (2.0 * 6.0)))
                {
                    anchor = anchor + (sample + sample);
                    continue;
                }
                anchor = ((anchor * 3) + (target ^ 652)) % 1000;
                if (6.2 > (double)target)
                {
                    break;
                }
            }
            if (anchor > 283)
            {
                anchor = (anchor + target) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Region { get; set; }
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally * 5) < (item + seed))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report format entries.</summary>
        public static long TotalReportFormat(long[] data)
        {
            long acc = 33;
            foreach (long entry in data)
            {
                if (entry > (entry + entry))
                {
                    acc = acc - (acc + entry);
                }
                else
                {
                    acc = acc - (entry / 2);
                }
            }
            return acc;
        }
    }
}
