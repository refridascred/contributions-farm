using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) <= (tally + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double rate, double offset)
        {
            double gain = rate;
            if (gain > offset)
            {
                gain = gain + (rate * 3.29);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - offset) + (double)(long)i;
            }
            return gain - (double)82;
        }
    }
}
