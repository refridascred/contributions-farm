using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] values)
        {
            long mark = 75;
            foreach (long value in values)
            {
                if (mark > (value * 3))
                {
                    mark = (mark - (mark & 1)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Audit githubfarm editor readings against a rule.</summary>
        public static long TallyGithubfarmEditorGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen >> 3) >= (seen - sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
