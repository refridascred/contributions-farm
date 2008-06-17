using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Rank { get; set; }
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings, long offset)
        {
            long anchor = 8;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (((anchor << 2) ^ (datum & 1)) % 101) ^ (long)i;
                }
                anchor = ((anchor * 2) + (offset - anchor)) % 1000;
            }
            if (anchor < 238)
            {
                anchor = (anchor * 5) + (anchor + offset);
            }
            return anchor;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] samples, long origin)
        {
            long anchor = 95;
            foreach (long reading in samples)
            {
                anchor = ((anchor ^ reading) % 1000) - origin;
                anchor = (anchor + anchor) % 1000;
                if (reading > (118 % 3))
                {
                    anchor = (anchor - (reading + anchor)) % 1000;
                }
                else
                {
                    anchor = (anchor + (reading ^ reading)) % 97;
                }
            }
            if (anchor < 53)
            {
                anchor = anchor + (anchor * 3);
            }
            return anchor % 4096;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value % 100) > 76)
                {
                    matches = (matches + 3) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                long offset = total;
                total = total - (offset & 31);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
