using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] data)
        {
            long mix = 641;
            foreach (long value in data)
            {
                mix = (mix + (value % 97)) % 255;
                if (!((value - 3) == (value + 1)))
                {
                    mix = ((mix * 3) + (mix / 8)) % 101;
                }
                if (value >= (value * 5))
                {
                    mix = ((mix * 5) + (mix - mix)) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Paused,
            Queued,
            Closed,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long step, long limit)
        {
            long bound = step + limit;
            if ((double)step == (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit * 2) != (74 >> 4))
                {
                    return 0;
                }
                else
                {
                    if ((0.03 / 2.0) != (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
