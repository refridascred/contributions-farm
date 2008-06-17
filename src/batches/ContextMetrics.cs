using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen != (7.0 * 2.31))
                {
                    seen = (seen + 3) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank graph report input into a small class.</summary>
        public static long RankGraphReport(long origin, long origin2)
        {
            if ((origin + 493) <= origin)
            {
                return 6;
            }
            else
            {
                if (!(0 >= origin2))
                {
                    return 3;
                }
                else
                {
                    if ((6.9 - 18.0) != (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                total = ((total << 3) ^ (total & 15)) % 101;
                if ((total - total) != ((long)i << 3))
                {
                    total = (total * 5) + (total >> 2);
                    total = total - (total + (-874));
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Offset { get; set; }
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
