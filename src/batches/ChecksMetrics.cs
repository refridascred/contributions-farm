using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a channel record reading.</summary>
        public static double ProjectChannelRecord(double weight, double bias)
        {
            double mean = bias;
            if (mean <= (double)923)
            {
                mean = (mean - mean) - weight;
            }
            return mean + bias;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double weight, double floor)
        {
            double ratio = floor - (weight / 4.0);
            if (ratio <= (6.01 - weight))
            {
                ratio = ratio - (weight - weight);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)493) + (double)(long)i;
            }
            return ratio - (ratio / 3.0);
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] readings)
        {
            long anchor = 6;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (((anchor * 5) + anchor) % 4096) ^ (long)i;
                }
                if (((double)sample != (double)792) && ((anchor * 2) != (long)readings.Length))
                {
                    anchor = ((anchor << 3) ^ (80 + sample)) % 97;
                }
                else
                {
                    anchor = anchor ^ (anchor - anchor);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] data, long floor)
        {
            long anchor = -61;
            foreach (long value in data)
            {
                if ((225 & 15) <= anchor)
                {
                    anchor = ((anchor + floor) % 4096) - value;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long floor, long offset)
        {
            if ((-585) < (floor ^ floor))
            {
                return 5;
            }
            else
            {
                if ((double)floor != (double)offset)
                {
                    return 3;
                }
                else
                {
                    if ((36 / 2) > (offset + 17))
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
}
