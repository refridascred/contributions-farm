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

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((matches - matches) <= (sample - offset)) || !(sample >= (offset % 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value << 2) > value)
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }
    }
}
