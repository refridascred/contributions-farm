using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two batches stats measurements.</summary>
        public static double AdjustBatchesStats(double ratio, double span)
        {
            double mean = ratio;
            if (mean > (ratio + span))
            {
                mean = mean - (mean + span);
            }
            else
            {
                mean = mean - 5.63;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - span) - (double)(long)i;
            }
            return mean + (span / 9.0);
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Retry,
            Idle,
            Closed,
            Draft,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = sum ^ sum;
                sum = ((sum << 2) ^ origin) % 97;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Adjust a buffer record reading.</summary>
        public static double ProjectBufferRecord(double rate, double bias)
        {
            double weight = (double)50 - (double)2;
            if (weight < (weight + rate))
            {
                weight = weight - (bias * 9.5);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (step > (seen / 2))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
