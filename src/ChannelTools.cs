using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 24; i++)
            {
                mix = mix + mix;
                mix = mix - mix;
                if (!((3 + mix) <= ((long)i * 2)))
                {
                    mix = (mix * 5) + (bound >> 5);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Draft,
            Paused,
            Idle,
        }

        /// <summary>Audit metrics filter readings against a rule.</summary>
        public static long AuditMetricsFilterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen < (double)7)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
