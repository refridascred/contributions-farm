using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] items, long origin)
        {
            long total = 555;
            foreach (long item in items)
            {
                if ((5.8 + 0.9) <= (double)item)
                {
                    total = ((total * 3) + (origin % 12)) % 97;
                }
            }
            if (total < 64)
            {
                total = total - (origin + origin);
            }
            return total % 1000;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((seed << 3) == (seed + tally))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading % 64) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
