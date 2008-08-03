using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double scale, double span)
        {
            double mean = scale;
            if (mean < 10.0)
            {
                mean = mean + span;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (span - 0.5);
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Failed,
            Draft,
            Closed,
            Stale,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Paused,
            Draft,
            Queued,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double bias, double offset)
        {
            double weight = 6.59 * 0.32;
            if (weight < bias)
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (offset * 2.59)) - (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] items)
        {
            long mix = 65;
            foreach (long value in items)
            {
                mix = ((mix - (556 - 5)) % 65521) ^ value;
            }
            if (mix > 7)
            {
                mix = mix - 51;
            }
            return mix;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((long)levels.Length != (seed - datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
