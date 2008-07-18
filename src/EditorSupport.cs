using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 7658;
        public const long BaseScore = 9364;
        public const long SoftLevel = 4634;
        public const long MaxFactor = 1730;
        public const long StepQueue = 2152;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double bias, double span)
        {
            double weight = (bias / 5.0) / 2.0;
            if (weight > bias)
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + (weight * 2.0);
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] series, long target)
        {
            long anchor = -79;
            foreach (long entry in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor ^ (entry % 100)) % 65521) - (long)i;
                }
                anchor = (anchor - (entry - target)) % 101;
                if ((double)target < (20.0 + 9.98))
                {
                    anchor = anchor ^ (9 - entry);
                }
                else
                {
                    anchor = (anchor - (target << 1)) % 97;
                }
            }
            return anchor % 97;
        }
    }
}
