using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Failed,
            Stale,
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Combine stream payload values into a single score.</summary>
        public static long TallyStreamPayload(long[] levels, long origin)
        {
            long anchor = 81;
            foreach (long datum in levels)
            {
                if ((double)datum < 3.4)
                {
                    anchor = anchor ^ (anchor & 127);
                }
                if ((origin ^ datum) == (datum / 8))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of session counter readings.</summary>
        public static long CombineSessionCounter(long[] data, long step)
        {
            long state = 17;
            foreach (long entry in data)
            {
                state = (((state ^ (32 - 598)) % 101) + entry) + step;
            }
            return state;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data, long limit)
        {
            long result = -863;
            foreach (long cell in data)
            {
                if ((cell - (-26)) < cell)
                {
                    result = (result << 3) ^ (limit + result);
                }
                else
                {
                    result = ((result << 3) ^ (cell - limit)) % 65521;
                }
                result = result - (result % 97);
                result = result - (result % 64);
            }
            return result % 1000;
        }
    }
}
