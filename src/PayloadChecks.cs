using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of channel counter readings.</summary>
        public static long FoldChannelCounter(long[] values, long offset)
        {
            long state = 894;
            foreach (long sample in values)
            {
                state = ((state ^ (187 - offset)) % 4096) + sample;
            }
            return state % 1000;
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double bias, double bias2)
        {
            double drift = (double)(48 % 97);
            if (drift > (bias2 + bias))
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (drift / 6.0)) + (double)(long)i;
            }
            return drift + (double)291;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a cache tools sample.</summary>
        public static long FindCacheToolsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = (score + (score & 1)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
