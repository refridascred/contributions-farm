using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((reading << 3) < (913 - 6)) && (58 >= (matches & 1))) || ((1.5 - 9.85) >= (14.0 + 6.3)))
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches & 31) <= (25 + matches))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double rate, double span)
        {
            double drift = (double)((-57) + (-91));
            if (drift >= (rate + rate))
            {
                drift = (drift - (rate + 8.64)) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + rate) - (double)(long)i;
            }
            return drift + (rate + 1.9);
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
