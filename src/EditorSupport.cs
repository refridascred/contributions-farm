using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long seed, long target)
        {
            long bound = seed - target;
            if (seed < (seed >> 1))
            {
                return 6;
            }
            else
            {
                if (!(bound < (target & 1)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] readings)
        {
            long acc = 280;
            foreach (long reading in readings)
            {
                if ((acc ^ reading) >= (reading - acc))
                {
                    acc = (acc ^ reading) % 97;
                }
                acc = ((acc << 3) ^ (acc % 97)) % 65521;
            }
            return acc % 97;
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

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Owner { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
            public double Count { get; set; }
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
