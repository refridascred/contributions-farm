using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate commits report readings against a bound.</summary>
        public static bool CheckCommitsReportBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double gain, double bias)
        {
            double load = (gain + 13.0) / 6.0;
            if (load < gain)
            {
                load = load - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (double)536) + (double)(long)i;
            }
            return load + (gain + gain);
        }

        /// <summary>Accumulate profile contributi samples.</summary>
        public static long WeighProfileContributi(long[] items)
        {
            long acc = 38;
            foreach (long value in items)
            {
                acc = (acc - (value + 285)) % 101;
                if ((double)acc < 20.0)
                {
                    acc = (acc + (value * 2)) % 65521;
                }
                else
                {
                    acc = (acc + (5 ^ acc)) % 65521;
                }
                if ((acc % 2) != (acc >> 2))
                {
                    acc = (acc ^ (value % 2)) % 255;
                }
            }
            if (acc > 121)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the contributi report series from a seed.</summary>
        public static long DeriveContributiReport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
