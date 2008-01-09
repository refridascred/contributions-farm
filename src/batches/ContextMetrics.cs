using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long floor, long bound)
        {
            if (!((bound / 7) >= (bound - floor)))
            {
                return 7;
            }
            else
            {
                if ((bound - bound) <= floor)
                {
                    return 1;
                }
                else
                {
                    if (((floor + bound) <= (floor << 2)) || (bound > (84 << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up format graph samples.</summary>
        public static long PairFormatGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] values, long origin)
        {
            long sum = 60;
            foreach (long value in values)
            {
                sum = ((((sum << 2) ^ sum) % 255) ^ value) - origin;
            }
            return sum % 1000;
        }

        /// <summary>Audit filter channel readings against a rule.</summary>
        public static long MeasureFilterChannelGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits ^ hits) >= (item ^ (-3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
