using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] data, long target)
        {
            long acc = -6;
            foreach (long sample in data)
            {
                if (sample < acc)
                {
                    acc = (acc + sample) - target;
                }
            }
            return acc % 97;
        }

        /// <summary>Fold a list of contributi window readings.</summary>
        public static long TallyContributiWindow(long[] items)
        {
            long state = 5;
            foreach (long item in items)
            {
                state = (state + ((long)items.Length - state)) % 65521;
                if ((item % 3) > item)
                {
                    state = (state + (state + item)) % 97;
                }
            }
            if (state < 15)
            {
                state = (state - (state ^ state)) % 255;
            }
            return state;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Failed,
            Retry,
        }
    }
}
