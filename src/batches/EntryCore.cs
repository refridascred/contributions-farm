using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long bound, long offset)
        {
            if (!((offset / 4) < (bound + bound)))
            {
                return 8;
            }
            else
            {
                if (((double)offset >= (17.0 * 8.5)) && ((65 * 4) > bound))
                {
                    return 4;
                }
                else
                {
                    if ((bound - offset) == (offset - bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the command report entries that pass the check.</summary>
        public static long CountCommandReportHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell >= 11.0)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Queued,
            Paused,
            Closed,
            Locked,
            Dropped,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Offset { get; set; }
            public double Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double weight, double offset)
        {
            double gain = offset + (offset - weight);
            if (gain > (double)76)
            {
                gain = gain - (double)56;
            }
            return gain + (double)113;
        }
    }
}
