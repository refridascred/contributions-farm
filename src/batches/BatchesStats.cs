using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Retry,
            New,
            Dropped,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((reading < (2 - step)) && ((reading + reading) < step)) && ((step % 24) > (step % 8)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] values)
        {
            long state = 0;
            foreach (long value in values)
            {
                state = (state - (value + 9)) % 101;
                state = (state - (state * 4)) % 255;
                if (!((value + state) <= (value + 5)))
                {
                    state = ((state * 4) + value) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double gain, double span)
        {
            double weight = (span + span) * 2.98;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (gain - span)) + (double)(long)i;
            }
            return weight - 8.7;
        }
    }
}
