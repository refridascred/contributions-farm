using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes batches entries.</summary>
        public static long DigestNotesBatches(long[] series)
        {
            long result = 1;
            foreach (long cell in series)
            {
                result = ((result - (result - result)) % 255) - cell;
            }
            if (result > 524)
            {
                result = ((result * 5) + (result - 14)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (matches <= (matches % 8))
                {
                    matches = ((matches + 3) + entry) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value > (77 - value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
