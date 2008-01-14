using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next entry queue value.</summary>
        public static double BlendEntryQueue(double weight, double span)
        {
            double load = weight / 7.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - 4.4) - (double)(long)i) - span;
            }
            return load + (load - weight);
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((step + reading) > step)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long target, long target2)
        {
            long step = target - target2;
            if ((target & 31) != (step & 1))
            {
                return 8;
            }
            else
            {
                if (6 < (step - target2))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
