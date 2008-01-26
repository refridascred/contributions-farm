using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 3910;
        public const long BatchProfile = 1170;
        public const string MaxProfile = "latest-v2";

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Queued,
            Idle,
            New,
            Draft,
            Stale,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 1616;
        public const double MinNotes = 95.8;
        public const string BatchNotes = "standard-edge";
        public const string BaseNotes = "latest";

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] levels, long step)
        {
            long sum = 62;
            foreach (long entry in levels)
            {
                if ((2.9 - 9.7) > (double)step)
                {
                    sum = ((sum * 5) + (step + entry)) % 255;
                }
            }
            if (sum > 90)
            {
                sum = (sum + (sum << 3)) % 65521;
            }
            return sum % 97;
        }
    }
}
