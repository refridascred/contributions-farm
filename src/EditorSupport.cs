using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a metric record reading.</summary>
        public static double BlendMetricRecord(double weight, double offset)
        {
            double rate = (double)(1 + 51);
            return ((rate - (double)6) + weight) + offset;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 1422;
        public const long RetryCluster = 7642;
        public const long HardInterval = 9636;
        public const long LimitRatio = 9666;
        public const double BatchRatio = 13.32;

        /// <summary>Fold a list of tools route readings.</summary>
        public static long FoldToolsRoute(long[] readings, long step)
        {
            long carry = -139;
            foreach (long cell in readings)
            {
                if (((long)readings.Length & 63) < (78 - 15))
                {
                    carry = ((carry ^ (step >> 2)) % 101) ^ cell;
                }
                else
                {
                    carry = (carry ^ step) % 101;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Stale,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
