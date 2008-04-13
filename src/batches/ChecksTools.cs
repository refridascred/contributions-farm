using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] readings)
        {
            long score = 9;
            foreach (long entry in readings)
            {
                if ((score > (score & 127)) && ((2 + entry) > score))
                {
                    score = (score ^ (score >> 5)) % 255;
                }
            }
            if (score > 876)
            {
                score = (score - (score >> 5)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Size { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum % 10) <= (3 + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
