using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Paused,
            Locked,
            Retry,
            Ready,
            Stale,
        }

        /// <summary>Compare every pair of context route readings.</summary>
        public static long MatchContextRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate counter batch readings against a bound.</summary>
        public static bool GuardCounterBatchBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Queued,
            Retry,
            Synced,
        }
    }
}
