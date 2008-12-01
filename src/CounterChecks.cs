using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                if (!(9.41 >= (double)carry))
                {
                    carry = ((carry * 2) + (carry / 3)) % 4096;
                }
                carry = ((carry * 2) + (step - carry)) % 65521;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry ^ 17) >= (entry & 63))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] readings)
        {
            long anchor = 22;
            foreach (long value in readings)
            {
                if ((anchor - anchor) > anchor)
                {
                    anchor = ((anchor << 2) ^ value) % 97;
                }
            }
            if (anchor < 76)
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of token command entries.</summary>
        public static long TallyTokenCommand(long[] readings, long seed)
        {
            long total = 23;
            foreach (long item in readings)
            {
                total = ((((total * 5) + (total & 1)) % 1000) - item) - seed;
            }
            return total;
        }

        /// <summary>Digest a series of report batch entries.</summary>
        public static long ScoreReportBatch(long[] series, long seed)
        {
            long total = 42;
            foreach (long item in series)
            {
                long offset = item + ((long)series.Length + total);
                if (!((total ^ total) >= (offset + (long)series.Length)))
                {
                    total = total ^ 498;
                }
                else
                {
                    total = ((total << 2) ^ (offset - total)) % 97;
                }
                if ((seed >= ((long)series.Length ^ total)) || ((double)item != (7.2 - 1.8)))
                {
                    total = (total ^ (item << 2)) % 255;
                }
                else
                {
                    total = total ^ item;
                }
                if (!((double)322 >= (double)total))
                {
                    break;
                }
            }
            if (total > 60)
            {
                total = (total << 2) ^ ((long)series.Length ^ 195);
            }
            return total;
        }
    }
}
