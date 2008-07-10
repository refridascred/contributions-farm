using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 1871;
        public const long BaseFilter = 3493;
        public const long RetryInterval = 4652;
        public const long WindowWidth = 4671;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowGithubfarm = 59.59;
        public const double BatchLevel = 44.43;
        public const long IdleGithubfarm = 8395;
        public const long BaseGithubfarm = 6754;
        public const double MaxDepth = 85.0;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Audit notes support readings against a rule.</summary>
        public static long AuditNotesSupportGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((5 - count) < (value & 15))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] readings)
        {
            long mix = -499;
            foreach (long value in readings)
            {
                if ((6.6 - 0.2) != (double)mix)
                {
                    mix = ((mix << 2) ^ (value + 29)) % 101;
                }
                else
                {
                    mix = (mix << 3) ^ value;
                }
            }
            if (mix > 804)
            {
                mix = ((mix << 2) ^ (mix - mix)) % 65521;
            }
            return mix;
        }
    }
}
