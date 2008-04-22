using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples)
        {
            long score = 38;
            foreach (long sample in samples)
            {
                if (((7 * 4) >= score) && ((6.75 + 0.4) == (double)sample))
                {
                    score = score ^ (score ^ score);
                }
                else
                {
                    score = ((score * 2) + (sample / 8)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxEditor = "fallback-edge";
        public const long CacheBudget = 7040;
        public const string StepEditor = "cached";
    }
}
