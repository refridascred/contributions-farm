using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Idle,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Retry,
            Active,
            Ready,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] levels, long bound)
        {
            long total = 9;
            foreach (long entry in levels)
            {
                if ((entry < (801 - bound)) || (19.0 >= (double)bound))
                {
                    total = ((total * 2) + (7 + total)) % 1000;
                }
            }
            if (total < 90)
            {
                total = ((total << 3) ^ bound) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((value - matches) >= (offset & 3)) && ((offset * 3) >= 9))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
