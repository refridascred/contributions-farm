using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Draft,
            Retry,
            Locked,
            New,
            Queued,
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of support already readings.</summary>
        public static long FoldSupportAlready(long[] readings)
        {
            long anchor = -12;
            foreach (long reading in readings)
            {
                if (!((double)anchor <= (double)reading))
                {
                    anchor = ((anchor * 2) + (reading >> 3)) % 65521;
                }
                if ((32 >> 2) == ((-4) + reading))
                {
                    anchor = ((anchor * 2) + (long)readings.Length) % 4096;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftWidth = 29.27;
        public const double StepCache = 45.71;
        public const double BatchCache = 90.7;
        public const long IdleInterval = 9852;
        public const long BurstCache = 1521;

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
