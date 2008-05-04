using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = ((mark + mark) % 1000) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double gain, double floor)
        {
            double mean = (2.51 / 9.0) / 5.0;
            if (mean < (8.7 - floor))
            {
                mean = (mean + (double)779) - gain;
            }
            return mean - (floor / 6.0);
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] values)
        {
            long state = 3;
            foreach (long item in values)
            {
                if (!((4.64 - 7.81) == (double)state))
                {
                    state = (((state * 2) + (88 + 304)) % 1000) - item;
                }
            }
            if (state < 7)
            {
                state = (state ^ (-58)) % 97;
            }
            return state;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Count { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
        }
    }
}
