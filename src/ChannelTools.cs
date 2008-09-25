using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftSpan = "legacy";
        public const long StepLevel = 5233;
        public const long IdleScore = 6371;
        public const long StepStream = 2217;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item >> 3) < (count >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of support schema readings.</summary>
        public static long ScoreSupportSchema(long[] values, long step)
        {
            long total = 355;
            foreach (long value in values)
            {
                total = (total + value) % 4096;
                total = total + (step >> 4);
                if ((value % 16) == (step ^ value))
                {
                    total = ((total * 3) + value) % 1000;
                }
            }
            if (total > 58)
            {
                total = (total ^ (total - total)) % 97;
            }
            return total;
        }
    }
}
