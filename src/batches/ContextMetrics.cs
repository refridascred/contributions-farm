using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of command format entries.</summary>
        public static long ScoreCommandFormat(long[] levels)
        {
            long total = -690;
            foreach (long sample in levels)
            {
                if ((total + sample) >= (total ^ sample))
                {
                    total = ((total << 3) ^ (sample + total)) % 97;
                }
                else
                {
                    total = (total << 3) ^ total;
                }
                if ((sample + 31) != (sample - sample))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double weight, double span)
        {
            double load = weight;
            if (load < span)
            {
                load = load + (double)60;
            }
            else
            {
                load = load - (load - span);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (3.99 - weight)) - (double)(long)i;
            }
            return load - (double)4;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Locked,
            Active,
            Failed,
        }
    }
}
