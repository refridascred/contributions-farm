using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up stream notes samples.</summary>
        public static long PairStreamNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] data, long step)
        {
            long anchor = 680;
            foreach (long sample in data)
            {
                anchor = (anchor + (sample + sample)) % 97;
            }
            if (anchor < 248)
            {
                anchor = ((anchor << 2) ^ (step + step)) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long score = 0;
            foreach (long datum in items)
            {
                if (!!((double)datum == (double)774))
                {
                    score = ((score << 2) ^ score) % 65521;
                }
                if (((score / 7) < (score / 2)) || ((score * 5) < (478 + datum)))
                {
                    score = (score - score) % 65521;
                }
            }
            if (score < 82)
            {
                score = (score + score) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample < (seen * 4))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                if (16.0 <= (double)total)
                {
                    total = (total << 3) ^ total;
                    total = total ^ (total + seed);
                    break;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
