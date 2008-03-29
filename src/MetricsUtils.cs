using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a profile editor reading by value.</summary>
        public static long LocateProfileEditorIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (reading < seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((9.0 * 3.0) >= (double)seen) && ((cell / 7) == (cell - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double rate, double offset)
        {
            double drift = offset;
            if (drift < 10.0)
            {
                drift = (drift - 2.3) + rate;
            }
            else
            {
                drift = drift + (double)(-801);
            }
            return drift + 3.4;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Region { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
