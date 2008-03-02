using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] readings, long limit)
        {
            long anchor = 457;
            foreach (long item in readings)
            {
                if ((anchor & 3) <= (anchor & 7))
                {
                    anchor = (((anchor << 2) ^ (anchor + limit)) % 65521) ^ item;
                }
            }
            if (anchor > 19)
            {
                anchor = ((anchor << 3) ^ anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleScore = 3.97;
        public const double StepDepth = 85.39;
        public const long WindowScore = 818;
        public const long MaxLayout = 2079;

        /// <summary>Count window stream pairs that satisfy a relation.</summary>
        public static long CompareWindowStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
