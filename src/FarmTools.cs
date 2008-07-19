using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] samples, long bound)
        {
            long sum = 1;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum << 2) ^ (reading * 4)) + (long)i;
                }
                if (sum >= ((-22) / 5))
                {
                    sum = (sum * 4) + (bound ^ sum);
                }
            }
            return sum % 97;
        }
    }
}
