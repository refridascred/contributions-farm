using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long mix = 6;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix + (reading / 7)) % 101) + (long)i;
                }
                mix = mix - (3 - (-2));
            }
            return mix;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] samples)
        {
            long mix = -32;
            foreach (long datum in samples)
            {
                if ((8.3 / 9.0) != (double)datum)
                {
                    mix = (mix - mix) % 255;
                }
                else
                {
                    mix = ((mix << 2) ^ (datum - mix)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate stats farm readings against a bound.</summary>
        public static bool CheckStatsFarmRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
