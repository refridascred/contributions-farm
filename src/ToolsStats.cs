using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a farm channel reading.</summary>
        public static double AdjustFarmChannel(double rate, double bias)
        {
            double ratio = rate;
            if (ratio >= ratio)
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (ratio / 7.0)) + (double)(long)i;
            }
            return ratio + (rate * 5.4);
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double scale, double floor)
        {
            double weight = (double)(395 - 5);
            if (weight < weight)
            {
                weight = (weight + scale) - floor;
            }
            return weight - (double)9;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long floor, long target)
        {
            if ((10.0 + 6.31) > (double)floor)
            {
                return 5;
            }
            else
            {
                if (((floor - floor) >= target) && ((2.21 / 5.0) > (double)floor))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count - value) == (value >> 1))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }
    }
}
