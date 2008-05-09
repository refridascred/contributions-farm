using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((((6.4 + 0.9) != (double)hits) || ((604 + hits) < item)) || (((long)series.Length << 2) == (item & 127)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] samples, long target)
        {
            long mix = 8;
            foreach (long item in samples)
            {
                mix = ((mix * 4) + 541) ^ item;
                mix = (mix + target) % 65521;
            }
            return mix % 1000;
        }
    }
}
