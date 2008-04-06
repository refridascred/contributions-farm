using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Locked,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double ratio, double bias)
        {
            double gain = ratio;
            if (gain <= gain)
            {
                gain = gain + (double)72;
            }
            else
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (bias - ratio)) + (double)(long)i;
            }
            return gain + (11.0 / 8.0);
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value <= (7.7 * 1.7))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = (score << 2) ^ target;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
