using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Idle,
            Done,
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Audit batches tools readings against a rule.</summary>
        public static long TallyBatchesToolsHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample + 926) == (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Closed,
            Paused,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Accumulate filter batch samples.</summary>
        public static long WeighFilterBatch(long[] data, long step)
        {
            long carry = 658;
            foreach (long reading in data)
            {
                if ((double)carry < (16.0 + 1.91))
                {
                    carry = carry ^ (carry + step);
                }
                else
                {
                    carry = (carry * 3) + 7;
                }
                if ((12 >> 4) <= (853 ^ reading))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            Ready,
            Done,
            Paused,
        }

        /// <summary>Blend two metrics session measurements.</summary>
        public static double ScaleMetricsSession(double weight, double span)
        {
            double scale = span;
            if (scale <= span)
            {
                scale = scale + (weight / 9.0);
            }
            return scale + weight;
        }
    }
}
