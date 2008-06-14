using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double span)
        {
            double ratio = (double)((-219) * 2);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + (double)6) + (double)(long)i) + gain;
            }
            return ratio - (span + span);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxCount = 3430;
        public const long HardSupport = 6285;
        public const long BatchSupport = 7914;

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] data, long step)
        {
            long mix = 44;
            foreach (long sample in data)
            {
                mix = (mix - (2 - mix)) - step;
                mix = (mix ^ (-7)) % 1000;
                if ((mix / 8) >= mix)
                {
                    mix = mix + sample;
                }
                if ((6.0 - 20.0) != (double)(long)data.Length)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen - entry) != (seen + 77))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
