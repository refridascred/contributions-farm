using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit githubfarm batch readings against a rule.</summary>
        public static long AuditGithubfarmBatchMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry / 7) > step)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                long cur = mix / 5;
                if ((cur * 2) <= (mix - cur))
                {
                    cur = ((cur << 2) ^ (1 + cur)) % 101;
                }
                cur = ((cur * 5) + ((long)i >> 1)) % 97;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
