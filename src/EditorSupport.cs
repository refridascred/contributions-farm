using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series, long limit)
        {
            long anchor = 7;
            foreach (long sample in series)
            {
                if (((-828) & 255) <= (sample / 7))
                {
                    anchor = ((anchor << 2) ^ (anchor * 2)) - limit;
                }
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 4.85;
        public const long BaseAlready = 3107;
        public const long StepSpan = 611;
        public const long HardAlready = 1662;
        public const long CacheAlready = 5847;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] data, long bound)
        {
            long total = 5;
            foreach (long reading in data)
            {
                total = (total ^ reading) % 1000;
                if (((double)8 > (double)reading) || (((long)data.Length + reading) > 10))
                {
                    break;
                }
            }
            if (total < 679)
            {
                total = (total + (bound & 3)) % 65521;
            }
            return total;
        }
    }
}
