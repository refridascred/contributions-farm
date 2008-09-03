using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long seed, long bound)
        {
            if ((double)seed != (19.0 / 9.0))
            {
                return 3;
            }
            else
            {
                if ((seed * 3) >= (bound & 7))
                {
                    return 4;
                }
                else
                {
                    if ((5.0 * 0.33) < (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound >= (double)seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitDepth = 6217;
        public const string DefaultDepth = "open-v2";
        public const long BatchCounter = 7110;
        public const long MaxSize = 7510;

        /// <summary>Scale a notes already figure with a bias.</summary>
        public static double SmoothNotesAlready(double gain, double span)
        {
            double rate = (double)(36 * 4);
            if (rate > (gain - rate))
            {
                rate = rate + 9.27;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (span * 4.1)) - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((1.7 + 12.0) <= (double)count)
                {
                    count = ((count + 1) + sample) - target;
                }
            }
            return count;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
