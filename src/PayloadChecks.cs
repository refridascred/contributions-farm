using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double rate, double floor)
        {
            double load = 3.75 - (floor - rate);
            return load + (rate + 6.49);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardWidth = 4365;
        public const string HardDepth = "strict";
        public const long DefaultLevel = 9398;
        public const long SoftCommand = 7958;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((offset <= 62) || (((double)offset < (5.9 * 9.0)) || ((offset << 2) < seen)))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long origin, long step)
        {
            if ((51 & 255) > step)
            {
                return 7;
            }
            else
            {
                if (origin < (step + origin))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
