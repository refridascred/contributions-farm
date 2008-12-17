using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= (floor * 4.99))
            {
                ratio = ratio + (floor - ratio);
            }
            else
            {
                ratio = ratio + (ratio - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)82) + (double)(long)i;
            }
            return ratio + (2.76 / 5.0);
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the order already entries that pass the check.</summary>
        public static long CountOrderAlreadyHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((datum + datum) != (37 * 2)) && !((origin - datum) <= ((-61) << 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Synced,
            Locked,
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] data)
        {
            long carry = 30;
            foreach (long entry in data)
            {
                if ((entry & 63) > (989 * 4))
                {
                    carry = ((carry * 3) + carry) % 101;
                }
                if ((carry > (entry ^ (long)data.Length)) || (58 >= (89 + entry)))
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
