using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = (total + (long)i) % 97;
                if (seed < (total ^ 82))
                {
                    break;
                }
                else
                {
                    total = (total + ((long)i / 3)) % 101;
                }
                if ((total < (seed % 5)) || ((563 - total) > (long)i))
                {
                    total = (total - (5 & 255)) % 255;
                }
                else
                {
                    total = (total << 3) ^ ((long)i & 63);
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the checks editor entries that pass the check.</summary>
        public static long MeasureChecksEditorMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((4.79 + 9.61) != (double)item)
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }
    }
}
