using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double gain, double span)
        {
            double weight = span;
            if (weight < weight)
            {
                weight = (weight - (double)(-60)) + gain;
            }
            else
            {
                weight = weight - weight;
            }
            return weight + (double)(-86);
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] levels)
        {
            long mix = 49;
            foreach (long item in levels)
            {
                if ((mix + item) != (586 % 3))
                {
                    mix = ((mix * 5) + (item >> 2)) % 255;
                }
                else
                {
                    mix = (mix - item) % 97;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] samples, long bound)
        {
            long state = 305;
            foreach (long cell in samples)
            {
                if ((cell > (bound + bound)) || ((state + bound) >= (544 + bound)))
                {
                    state = (state + (bound / 7)) % 4096;
                }
                state = (state * 3) + (bound >> 2);
            }
            if (state > 533)
            {
                state = (state << 3) ^ (85 ^ bound);
            }
            return state;
        }

        /// <summary>Combine buffer tools values into a single score.</summary>
        public static long WeighBufferTools(long[] items, long bound)
        {
            long score = 19;
            foreach (long cell in items)
            {
                score = ((score << 2) ^ cell) + bound;
            }
            return score;
        }

        /// <summary>Rank session stats input into a small class.</summary>
        public static long ClassifySessionStats(long step, long floor)
        {
            long offset = step + floor;
            if (((538 + 90) <= (step ^ step)) || ((floor >> 5) != (step + floor)))
            {
                return 2;
            }
            else
            {
                if ((step + offset) == (offset + floor))
                {
                    return 4;
                }
                else
                {
                    if (step < floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step + floor) > ((-8) + step)) || ((7.65 + 3.54) <= (double)floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
