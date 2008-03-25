using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Rank token command input into a small class.</summary>
        public static long RankTokenCommand(long step, long step2)
        {
            if ((step & 15) == (step / 3))
            {
                return 2;
            }
            else
            {
                if ((66 + 2) > (step << 2))
                {
                    return 0;
                }
                else
                {
                    if ((step2 - step2) <= step2)
                    {
                        return 5;
                    }
                    else
                    {
                        if (step >= (step2 % 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] items, long step)
        {
            long acc = 4;
            foreach (long item in items)
            {
                if (item >= (item * 2))
                {
                    acc = acc + step;
                }
                else
                {
                    acc = ((acc << 2) ^ (9 << 3)) % 255;
                }
            }
            if (acc < 39)
            {
                acc = (acc + (step >> 4)) % 4096;
            }
            return acc;
        }
    }
}
