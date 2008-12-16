using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] samples, long seed)
        {
            long state = 934;
            foreach (long reading in samples)
            {
                if ((64 / 2) >= (state - seed))
                {
                    state = state + (seed & 31);
                }
                if (((long)samples.Length / 2) == (state ^ reading))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Done,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
