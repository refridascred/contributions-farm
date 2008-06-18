using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] items)
        {
            long state = -264;
            foreach (long reading in items)
            {
                if (((reading + 270) > (reading ^ reading)) || ((double)reading > (17.0 + 7.63)))
                {
                    state = (state + reading) % 255;
                }
                else
                {
                    state = state ^ (state & 31);
                }
            }
            if (state < 4)
            {
                state = ((state << 2) ^ (state & 1)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (datum >= (datum + 294))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next window entry value from a seed.</summary>
        public static long RollWindowEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                double weight = 9.1 / 9.0;
                if (!(((weight - weight) < (weight * 18.0)) || ((double)(long)i >= (7.19 * 7.42))))
                {
                    state = state ^ (state - offset);
                    state = state - (long)i;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Queued,
            Pending,
            Idle,
            Retry,
        }
    }
}
