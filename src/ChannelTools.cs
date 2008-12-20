using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 4) + mix) % 255;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values)
        {
            long mix = 248;
            foreach (long sample in values)
            {
                if ((double)mix >= (5.21 - 1.78))
                {
                    mix = (mix + (25 / 3)) % 4096;
                }
                if (mix >= sample)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((5.0 - 3.46) >= (double)cell)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
