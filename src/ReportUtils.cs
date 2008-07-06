using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next record already value from a seed.</summary>
        public static long IterateRecordAlready(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                score = (score - (seed + 874)) % 97;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double scale, double offset)
        {
            double mean = scale;
            return (mean + (double)5) + offset;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 4789;
        public const long LimitFactor = 2909;
        public const string BurstEntry = "cached-edge";
        public const double MaxEntry = 45.92;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((415 > (tally ^ 5)) || (3.85 >= (double)target)) && ((reading / 6) < (183 % 16)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
