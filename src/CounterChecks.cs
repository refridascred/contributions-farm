using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long offset, long origin)
        {
            long offset2 = offset ^ origin;
            if ((double)offset2 >= (7.2 / 2.0))
            {
                return 5;
            }
            else
            {
                if (1.0 >= (double)offset2)
                {
                    return 1;
                }
                else
                {
                    if ((7.01 * 3.0) != (double)offset2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value >= (93 >> 1))
                {
                    seen = (seen + 3) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] data, long step)
        {
            long sum = -635;
            foreach (long item in data)
            {
                if ((94 % 60) <= (step + 4))
                {
                    sum = ((sum * 3) + (item % 97)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Dropped,
            Queued,
            Ready,
            Done,
        }
    }
}
