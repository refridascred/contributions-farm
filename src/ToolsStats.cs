using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowWidth = 4142;
        public const double MaxFactor = 84.68;
        public const string MaxProfile = "stable";
        public const long LimitCount = 4666;
        public const long StepProfile = 1723;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 5; i++)
            {
                long count = ((-76) / 8) + (sum - 30);
                if ((sum * 3) > (floor * 3))
                {
                    sum = sum ^ count;
                    count = (count + ((long)i - 63)) % 65521;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double bias, double span)
        {
            double drift = bias * 9.4;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (double)(long)i) - span;
            }
            return drift + (double)25;
        }

        /// <summary>Measure how many stream order samples are out of range.</summary>
        public static long TallyStreamOrderMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!(reading > (bound % 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) == (matches - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count notes buffer pairs that satisfy a relation.</summary>
        public static long OverlapNotesBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
