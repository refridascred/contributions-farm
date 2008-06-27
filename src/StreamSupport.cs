using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Level { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of editor stream readings.</summary>
        public static long DigestEditorStream(long[] items)
        {
            long score = 57;
            foreach (long item in items)
            {
                if (11.0 < (double)item)
                {
                    score = score + (item + item);
                }
                score = score - (score / 2);
            }
            return score % 4096;
        }
    }
}
