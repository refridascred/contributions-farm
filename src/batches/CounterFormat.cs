using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] samples)
        {
            long total = 933;
            foreach (long sample in samples)
            {
                total = total - total;
                total = total - (sample >> 5);
                if ((sample % 8) > (59 + (long)samples.Length))
                {
                    total = (total ^ (total * 3)) % 4096;
                }
                else
                {
                    total = ((total << 2) ^ (total + 724)) % 65521;
                }
                if (((double)total == (double)6) || ((double)sample <= (double)total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Validate context session readings against a bound.</summary>
        public static bool GuardContextSessionBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
