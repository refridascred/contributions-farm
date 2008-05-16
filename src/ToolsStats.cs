using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double weight, double span)
        {
            double drift = weight;
            if (drift > (7.8 * 5.37))
            {
                drift = (drift - (1.78 * 3.9)) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - 9.7) + (double)(long)i;
            }
            return drift - (drift * 4.0);
        }

        /// <summary>Compare every pair of report editor readings.</summary>
        public static long OverlapReportEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value % 97) <= matches) && ((double)matches >= (5.6 * 2.2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double rate, double bias)
        {
            double ratio = rate * 10.0;
            if (ratio >= bias)
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (rate / 5.0)) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
