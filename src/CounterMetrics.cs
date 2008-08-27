using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Iterate the metric layout series from a seed.</summary>
        public static long IterateMetricLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] data)
        {
            long mix = 911;
            foreach (long value in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = (((mix * 5) + (mix % 97)) % 4096) + (long)i;
                }
                if ((mix % 3) <= value)
                {
                    mix = mix + ((long)data.Length - value);
                }
            }
            return mix;
        }
    }
}
