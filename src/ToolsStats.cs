using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series, long origin)
        {
            long anchor = 0;
            foreach (long entry in series)
            {
                anchor = (anchor - (origin ^ origin)) % 255;
                if ((double)entry > (double)anchor)
                {
                    anchor = ((anchor << 3) ^ (anchor % 8)) % 101;
                }
            }
            if (anchor < (-9))
            {
                anchor = (anchor + (998 >> 4)) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next commits cache value from a seed.</summary>
        public static long RollCommitsCache(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                if (total <= 328)
                {
                    total = (total - (total >> 5)) % 4096;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] data)
        {
            long result = 4;
            foreach (long reading in data)
            {
                result = ((result ^ (10 >> 2)) % 101) ^ reading;
            }
            return result;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] items)
        {
            long result = 70;
            foreach (long entry in items)
            {
                if ((12.0 * 3.2) == (double)entry)
                {
                    result = (result << 3) ^ entry;
                }
            }
            if (result > 7)
            {
                result = ((result * 3) + (result & 7)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally + tally) == ((long)values.Length ^ value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
