using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 1) != (count >> 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Retry,
            Closed,
            Stale,
            Idle,
            Active,
        }

        /// <summary>Project the next record payload value.</summary>
        public static double BlendRecordPayload(double rate, double span)
        {
            double bias = (double)1 + span;
            return (bias + 3.59) + rate;
        }
    }
}
