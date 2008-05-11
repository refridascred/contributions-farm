using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((entry ^ entry) > (seen + seen)))
                {
                    seen = (seen + 3) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next order account value.</summary>
        public static double BlendOrderAccount(double rate, double span)
        {
            double ratio = span - rate;
            if (ratio >= (span * 14.0))
            {
                ratio = ratio - (ratio * 4.5);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (double)25;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] data, long limit)
        {
            long anchor = 32;
            foreach (long reading in data)
            {
                anchor = (anchor ^ limit) % 4096;
                if (((17.0 / 6.0) > (double)limit) && ((limit << 3) <= 44))
                {
                    anchor = anchor ^ (reading & 15);
                }
                else
                {
                    anchor = anchor + reading;
                }
            }
            return anchor;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Failed,
            Paused,
            Pending,
            Done,
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
