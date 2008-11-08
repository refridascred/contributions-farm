using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            New,
            Queued,
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Derive the next window githubfarm value from a seed.</summary>
        public static long StepWindowGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!!((303 * 3) != (entry + 1)))
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally & 7) >= (tally >> 4))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)datum != (2.2 + 10.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
