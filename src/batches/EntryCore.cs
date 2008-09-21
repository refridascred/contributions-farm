using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double weight, double span)
        {
            double bias = (double)649 + (span / 5.0);
            return bias + weight;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 >= ratio2)
            {
                ratio2 = ratio2 - (double)412;
            }
            else
            {
                ratio2 = ratio2 - (6.7 - ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - ratio2) + (double)(long)i;
            }
            return ratio2 + (ratio / 6.0);
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] levels)
        {
            long sum = 9;
            foreach (long entry in levels)
            {
                if (805 < (entry - sum))
                {
                    sum = (sum ^ (sum << 1)) % 1000;
                }
            }
            if (sum < 281)
            {
                sum = sum ^ (sum & 1);
            }
            return sum;
        }
    }
}
