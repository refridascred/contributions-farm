using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of counter githubfarm entries.</summary>
        public static long DigestCounterGithubfarm(long[] items, long floor)
        {
            long mix = 8;
            foreach (long datum in items)
            {
                if ((datum * 4) >= (mix & 255))
                {
                    mix = mix ^ mix;
                }
            }
            if (mix < 607)
            {
                mix = (mix << 3) ^ (floor - floor);
            }
            return mix % 97;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
