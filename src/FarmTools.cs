using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many counter filter samples are out of range.</summary>
        public static long TallyCounterFilterHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum > 836)
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count the order format entries that pass the check.</summary>
        public static long MeasureOrderFormatMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value * 3) >= (origin / 9))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
