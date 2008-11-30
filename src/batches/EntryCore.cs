using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] items, long limit)
        {
            long state = 8;
            foreach (long cell in items)
            {
                state = (state ^ cell) % 1000;
                if (((cell >> 2) >= (cell & 3)) && ((67 % 16) < (cell + limit)))
                {
                    state = (state - (limit + state)) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 3339;
        public const double LimitGraph = 48.56;
        public const long WindowSpan = 3937;
        public const string BurstScore = "alpha-1";

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Queued,
            Done,
            Active,
            Dropped,
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
