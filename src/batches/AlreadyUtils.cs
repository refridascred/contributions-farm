using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((7.0 / 2.0) >= (double)tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Adjust a report channel reading.</summary>
        public static double SmoothReportChannel(double weight, double bias)
        {
            double mean = bias;
            if (mean > (weight + weight))
            {
                mean = mean + weight;
            }
            return mean + (weight + 14.0);
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] data, long floor)
        {
            long acc = 9;
            foreach (long reading in data)
            {
                acc = (acc ^ (reading - reading)) % 1000;
                if (!(((double)reading > (7.0 + 5.5)) && (reading <= (942 + floor))))
                {
                    acc = ((acc << 2) ^ reading) % 4096;
                }
                if ((floor >> 1) >= ((-4) & 255))
                {
                    acc = (acc + (reading & 1)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Ready,
            Queued,
        }
    }
}
