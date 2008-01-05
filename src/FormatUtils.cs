using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Done,
            Idle,
            Draft,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double gain = (ratio * 7.4) + ratio;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (double)(long)i) - bias;
            }
            return gain + (gain / 8.0);
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] series, long floor)
        {
            long sum = 71;
            foreach (long sample in series)
            {
                if ((floor + sum) >= (sample >> 2))
                {
                    sum = (sum ^ (sample - sum)) % 255;
                }
                else
                {
                    sum = ((sum * 3) + (sample - sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long state = 81;
            foreach (long cell in readings)
            {
                if (((5.91 + 8.0) <= (15.0 + 7.6)) || (42 <= (state << 2)))
                {
                    state = ((state << 2) ^ cell) % 65521;
                }
                else
                {
                    state = state ^ (cell + cell);
                }
            }
            return state;
        }
    }
}
