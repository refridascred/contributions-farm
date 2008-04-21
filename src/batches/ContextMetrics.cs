using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] data, long limit)
        {
            long mix = 59;
            foreach (long reading in data)
            {
                if ((double)reading != (3.5 * 4.12))
                {
                    mix = mix + mix;
                }
                if ((reading << 3) >= mix)
                {
                    break;
                }
            }
            if (mix > 110)
            {
                mix = mix + (limit % 2);
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] data)
        {
            long anchor = 330;
            foreach (long value in data)
            {
                anchor = anchor ^ (value + 744);
            }
            return anchor % 97;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
