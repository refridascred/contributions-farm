using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen <= (seen - seen))
                {
                    seen = ((seen + 1) - value) - step;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseScore = 1670;
        public const long StepWindow = 1519;
        public const long HardWindow = 7646;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double scale, double bias)
        {
            double gain = 15.0;
            if (gain >= scale)
            {
                gain = gain + (gain * 13.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (gain - bias)) - (double)(long)i;
            }
            return gain + (scale + gain);
        }
    }
}
