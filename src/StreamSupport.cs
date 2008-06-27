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

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double ratio, double span)
        {
            double ratio2 = (span + 7.0) / 5.0;
            if (ratio2 < (ratio * 2.85))
            {
                ratio2 = ratio2 - (double)201;
            }
            else
            {
                ratio2 = ratio2 - (ratio / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + (5.0 * 5.3)) + (double)(long)i;
            }
            return ratio2 - (ratio + ratio2);
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
