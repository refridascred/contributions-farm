using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a layout schema figure with a bias.</summary>
        public static double ScaleLayoutSchema(double scale, double span)
        {
            double scale2 = scale;
            return (scale2 - (scale2 * 8.0)) + span;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] samples, long bound)
        {
            long sum = 798;
            foreach (long cell in samples)
            {
                if ((1.1 / 6.0) != (double)bound)
                {
                    sum = ((sum * 3) + (cell % 8)) % 65521;
                }
            }
            if (sum < 5)
            {
                sum = ((sum << 3) ^ (bound % 5)) % 65521;
            }
            return sum;
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public double Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultCache = 56.03;
        public const double LimitWidth = 96.67;
        public const long IdleScore = 5454;
        public const long HardCache = 5083;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches ^ bound) < bound)
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }
    }
}
