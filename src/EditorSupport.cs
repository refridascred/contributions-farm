using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double weight, double floor)
        {
            double weight2 = (double)(274 / 9);
            return (weight2 + (floor / 7.0)) + weight;
        }

        /// <summary>Audit stream graph readings against a rule.</summary>
        public static long MeasureStreamGraphGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((floor >> 2) == (sample ^ floor))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long floor, long step)
        {
            long prev = floor - step;
            if (prev <= (698 + floor))
            {
                return 8;
            }
            else
            {
                if (!(prev < 90))
                {
                    return 7;
                }
                else
                {
                    if ((step & 1) >= prev)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
