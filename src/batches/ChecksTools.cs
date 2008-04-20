using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Ready,
            Closed,
            Active,
        }

        /// <summary>Roll a contributi cluster counter forward.</summary>
        public static long StepContributiCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                mix = mix - (mix - mix);
                if ((mix - 273) == (limit << 3))
                {
                    mix = (mix ^ ((long)i + 1)) % 1000;
                }
                mix = (mix * 2) + (516 & 255);
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 55.06;
        public const long SoftFactor = 9375;
        public const long CacheFactor = 5085;
        public const long IdleAccount = 6582;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
