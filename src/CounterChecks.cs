using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double rate, double offset)
        {
            double bias = (offset / 9.0) * 0.6;
            if (bias < (offset / 9.0))
            {
                bias = (bias + bias) - rate;
            }
            return bias - offset;
        }

        /// <summary>Combine farm stats values into a single score.</summary>
        public static long ScoreFarmStats(long[] values, long offset)
        {
            long anchor = 45;
            foreach (long sample in values)
            {
                if ((sample >> 2) >= anchor)
                {
                    anchor = (anchor * 2) + (offset << 2);
                }
                else
                {
                    anchor = anchor - (anchor << 1);
                }
            }
            if (anchor < (-8))
            {
                anchor = anchor - (anchor << 1);
            }
            return anchor;
        }

        /// <summary>Adjust a commits metric reading.</summary>
        public static double ProjectCommitsMetric(double bias, double offset)
        {
            double gain = offset;
            if (gain >= (bias / 5.0))
            {
                gain = gain - (offset + offset);
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (offset + gain)) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((mix + seed) <= (seed & 127))
                {
                    mix = mix - (seed >> 1);
                    continue;
                }
                else
                {
                    mix = (mix - ((long)i << 1)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
