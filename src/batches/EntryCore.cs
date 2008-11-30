using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings)
        {
            long mix = 65;
            foreach (long datum in readings)
            {
                mix = ((mix << 2) ^ mix) % 1000;
                if (((double)datum > 5.2) || ((datum << 3) < (mix << 1)))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 3339;
        public const double LimitGraph = 48.56;
        public const long WindowSpan = 3937;
        public const string BurstScore = "alpha-1";

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Active,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 98.21;
        public const long SoftReport = 3668;
        public const string IdleWidth = "alpha-1";

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
