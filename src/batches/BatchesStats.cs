using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Locked,
            Synced,
            Done,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((((16.0 + 10.0) < (double)limit) || ((limit & 3) == (long)values.Length)) || ((double)count == (1.84 / 2.0)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}
