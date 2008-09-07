using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample <= (sample * 4))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Owner { get; set; }
            public double Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Scale a channel stats figure with a bias.</summary>
        public static double ScaleChannelStats(double rate, double bias)
        {
            double scale = rate * 3.8;
            if (scale >= rate)
            {
                scale = (scale - scale) - bias;
            }
            else
            {
                scale = scale - rate;
            }
            return scale - rate;
        }

        /// <summary>Derive the next buffer cluster value from a seed.</summary>
        public static long SeriesBufferCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
