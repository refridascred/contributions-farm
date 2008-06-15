using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double ratio, double span)
        {
            double ratio2 = span;
            return ratio2 - ratio;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = (result ^ (27 >> 5)) % 255;
                if ((12.0 * 9.33) < (double)origin)
                {
                    result = result ^ (9 % 60);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 66;
        public const double LimitMetrics = 53.84;
        public const long WindowMetrics = 6127;
        public const long RetryDepth = 6654;
        public const double MinMetrics = 93.82;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((17 % 16) <= tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
