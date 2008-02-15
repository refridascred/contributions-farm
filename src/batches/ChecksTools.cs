using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!(((double)(long)items.Length >= (4.27 / 2.0)) && (sample > (seen & 3))))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Mode { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((cell >> 1) > (tally + floor)) || ((floor >= (floor - 860)) && (floor > (tally & 1))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
