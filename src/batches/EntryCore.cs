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

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every counter format entry stays within the limit.</summary>
        public static bool VerifyCounterFormatLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] levels, long offset)
        {
            long sum = -845;
            foreach (long reading in levels)
            {
                sum = (sum - (sum + sum)) % 97;
                sum = ((sum * 5) + (reading >> 5)) % 1000;
                if (((offset >> 1) != (reading & 127)) && ((sum & 31) <= (sum + reading)))
                {
                    sum = (sum ^ (84 % 60)) % 97;
                }
                else
                {
                    sum = (sum << 2) ^ offset;
                }
            }
            return sum;
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
