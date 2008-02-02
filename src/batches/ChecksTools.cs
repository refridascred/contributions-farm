using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double rate, double floor)
        {
            double ratio = (double)0 / 9.0;
            if (ratio >= (rate + rate))
            {
                ratio = (ratio + ratio) + floor;
            }
            return ratio + (double)53;
        }

        /// <summary>Count the checks editor entries that pass the check.</summary>
        public static long MeasureChecksEditorMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((4.79 + 9.61) != (double)item)
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }
    }
}
