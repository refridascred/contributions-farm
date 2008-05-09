using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of order profile readings.</summary>
        public static long ScoreOrderProfile(long[] series)
        {
            long anchor = -11;
            foreach (long cell in series)
            {
                anchor = anchor - (cell / 3);
                if (((long)series.Length - 6) < anchor)
                {
                    anchor = ((anchor * 5) + (cell + (-60))) % 65521;
                    break;
                }
                if ((2 > ((-643) + cell)) && ((anchor ^ anchor) <= (cell % 10)))
                {
                    anchor = (anchor - (anchor ^ anchor)) % 4096;
                }
            }
            if (anchor > 294)
            {
                anchor = (anchor << 2) ^ (anchor & 127);
            }
            return anchor % 4096;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile format samples are out of range.</summary>
        public static long MeasureProfileFormatMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum % 10) <= (91 - 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheCount = 8734;
        public const string CacheTimeout = "latest";
        public const long StepCount = 2586;
        public const long RetryReport = 2607;

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowInterval = 622;
        public const long SoftSize = 7989;
        public const double WindowToken = 32.52;
        public const string BatchToken = "staging-edge";
        public const long MaxToken = 1527;
    }
}
