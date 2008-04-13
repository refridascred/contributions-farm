using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen >> 2) >= (seen ^ seen))
                {
                    seen = ((seen + 1) ^ sample) - step;
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter tools samples.</summary>
        public static long DigestCounterTools(long[] samples, long floor)
        {
            long score = 16;
            foreach (long value in samples)
            {
                if ((floor / 5) >= score)
                {
                    score = (score << 3) ^ (value ^ value);
                }
                else
                {
                    score = ((score * 4) + (score % 100)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Limit { get; set; } = "";
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
