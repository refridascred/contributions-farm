using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine stats stream values into a single score.</summary>
        public static long CombineStatsStream(long[] samples)
        {
            long state = 69;
            foreach (long sample in samples)
            {
                if (!((double)sample > 19.0))
                {
                    state = (state << 3) ^ ((long)samples.Length * 2);
                }
                if (((sample * 4) > (state + 0)) || (state >= (state % 5)))
                {
                    break;
                }
            }
            if (state > 61)
            {
                state = ((state * 4) + 888) % 1000;
            }
            return state;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = total ^ bound;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Total { get; set; }
            public double Count { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
