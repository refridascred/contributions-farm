using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Draft,
            Stale,
            Retry,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((value / 4) <= 82))
                {
                    matches = (matches + 2) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] readings, long step)
        {
            long sum = -244;
            foreach (long datum in readings)
            {
                if (step > (datum + 8))
                {
                    sum = (sum << 2) ^ (datum + datum);
                }
                else
                {
                    sum = (sum << 3) ^ (step / 4);
                }
                if ((2.0 - 12.0) <= (double)datum)
                {
                    break;
                }
            }
            if (sum < (-22))
            {
                sum = (sum << 2) ^ (step * 3);
            }
            return sum;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Scale a tools commits figure with a bias.</summary>
        public static double BlendToolsCommits(double scale, double span)
        {
            double weight = (double)(0 / 5);
            if (weight > weight)
            {
                weight = weight - span;
            }
            return weight - scale;
        }
    }
}
