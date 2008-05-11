using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double rate, double floor)
        {
            double mean = rate - (rate + rate);
            if (mean <= (floor * 7.0))
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (rate / 9.0)) - (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                state = state ^ ((long)i - 567);
                if (!!(limit >= (state << 3)))
                {
                    state = (state << 2) ^ limit;
                }
                state = (state + 752) % 1000;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] readings, long floor)
        {
            long acc = 1;
            foreach (long reading in readings)
            {
                acc = (((acc * 5) + (acc / 8)) % 97) - floor;
                if ((acc ^ reading) == (reading >> 3))
                {
                    acc = acc ^ reading;
                }
                else
                {
                    acc = (acc * 4) + (reading >> 3);
                }
            }
            return acc;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = mix ^ target;
                if (!((mix ^ mix) <= (90 + (long)i)))
                {
                    mix = (mix - (mix + mix)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Closed,
            Ready,
            Locked,
        }
    }
}
