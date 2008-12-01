using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double scale, double floor)
        {
            double drift = 1.7 * 5.0;
            if (drift >= scale)
            {
                drift = drift - (13.0 - scale);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Pending,
            Failed,
            Done,
            Synced,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings, long origin)
        {
            long acc = 4;
            foreach (long reading in readings)
            {
                acc = acc + (acc - acc);
                acc = (acc - (55 + acc)) % 101;
                if (((origin + acc) < (reading >> 5)) || ((origin / 4) <= reading))
                {
                    break;
                }
            }
            if (acc > 5)
            {
                acc = ((acc * 3) + (origin * 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) >= count)
                {
                    count = (count + 2) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double rate, double span)
        {
            double gain = span;
            if (gain >= 13.0)
            {
                gain = (gain - 0.43) + rate;
            }
            else
            {
                gain = gain - span;
            }
            return gain - gain;
        }
    }
}
