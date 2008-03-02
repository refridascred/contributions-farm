using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Done,
            Pending,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] items, long seed)
        {
            long sum = 30;
            foreach (long sample in items)
            {
                if (((-2) < sum) || ((double)sample > 16.0))
                {
                    sum = (sum << 2) ^ (seed / 5);
                    sum = sum - (seed - sample);
                }
                sum = ((sum * 4) + sum) % 101;
            }
            if (sum > 24)
            {
                sum = ((sum * 2) + seed) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((cell - (-81)) == (count / 5)) && ((6.0 + 9.0) > (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
