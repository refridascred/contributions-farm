using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double scale, double floor)
        {
            double mean = (floor / 2.0) + floor;
            if (mean < (mean - floor))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + (double)45;
            }
            return mean - scale;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double scale, double span)
        {
            double load = scale;
            if (load < span)
            {
                load = load + span;
            }
            else
            {
                load = load - (double)798;
            }
            return load - scale;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Synced,
            Locked,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((5.4 + 0.1) == (double)item) || ((double)tally >= 5.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate counter filter readings against a bound.</summary>
        public static bool GuardCounterFilterLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
