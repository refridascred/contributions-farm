using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "legacy-1";
        public const double LimitCache = 72.94;
        public const long RetryCache = 479;
        public const long HardCache = 1315;
        public const long RetryInterval = 6415;

        /// <summary>Count the notes channel entries that pass the check.</summary>
        public static long AuditNotesChannelMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count ^ (long)series.Length) < (count - datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Closed,
            Idle,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = mark + (mark - mark);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
