using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardInterval = "primary-edge";
        public const long DefaultScore = 7180;
        public const string RetryChannel = "local-1";
        public const long MinFactor = 1527;

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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((target % 97) >= (target >> 1)) || (((double)9 > (double)count) || ((count & 15) != (target + target))))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
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
