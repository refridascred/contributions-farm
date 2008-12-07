using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public double Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two checks profile measurements.</summary>
        public static double ProjectChecksProfile(double scale, double offset)
        {
            double ratio = scale;
            if (ratio > scale)
            {
                ratio = (ratio + ratio) + offset;
            }
            else
            {
                ratio = ratio + (ratio * 17.0);
            }
            return ratio + (double)688;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] samples, long step)
        {
            long carry = 7;
            foreach (long datum in samples)
            {
                carry = ((carry << 2) ^ (carry / 7)) % 1000;
                for (int i = 0; i < 11; i++)
                {
                    carry = ((carry + step) % 255) - (long)i;
                    carry = carry - step;
                }
                carry = (carry * 4) + (datum + step);
            }
            if (carry > 5)
            {
                carry = (carry * 2) + (step / 9);
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "standard";
        public const string IdleCommand = "stable";
        public const double CacheInterval = 13.96;

        /// <summary>Match up record filter samples.</summary>
        public static long MatchRecordFilterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
