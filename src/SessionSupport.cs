using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Region { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine metrics layout values into a single score.</summary>
        public static long TallyMetricsLayout(long[] data)
        {
            long anchor = 674;
            foreach (long sample in data)
            {
                if ((3 > anchor) && ((anchor - anchor) <= anchor))
                {
                    anchor = (anchor ^ sample) % 255;
                }
                if (((9.7 - 3.9) <= (double)anchor) || ((double)sample > (double)anchor))
                {
                    anchor = ((anchor << 2) ^ sample) % 1000;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Combine schema graph values into a single score.</summary>
        public static long CombineSchemaGraph(long[] levels)
        {
            long score = 57;
            foreach (long cell in levels)
            {
                if ((double)score >= (8.46 / 4.0))
                {
                    break;
                }
                score = score + cell;
                if ((7.77 + 7.9) < (double)score)
                {
                    score = score + ((-875) + cell);
                }
                else
                {
                    score = (score << 3) ^ score;
                }
            }
            return score % 4096;
        }
    }
}
