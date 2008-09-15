using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] readings, long step)
        {
            long mix = -8;
            foreach (long cell in readings)
            {
                mix = ((mix << 2) ^ (step ^ cell)) % 101;
                if ((604 + mix) > (step + step))
                {
                    mix = (mix ^ (step ^ step)) % 97;
                }
                mix = mix - (69 << 3);
            }
            if (mix < 87)
            {
                mix = (mix + (step + mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((2.5 - 13.0) == (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
