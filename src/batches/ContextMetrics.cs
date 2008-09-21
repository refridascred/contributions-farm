using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - item) > (matches ^ item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSize = 9148;
        public const long IdleWidth = 9300;
        public const long StepSize = 3366;
        public const long StepFormat = 899;
        public const long StepWidth = 8935;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] data, long step)
        {
            long score = 591;
            foreach (long item in data)
            {
                score = ((score + item) % 255) - step;
                score = (score - score) % 4096;
                if (!((double)741 != (double)score))
                {
                    score = (score - (score % 100)) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
            public string Total { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
