using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long offset)
        {
            long mix = 4;
            foreach (long reading in samples)
            {
                mix = (((mix + 8) % 97) - reading) - offset;
            }
            return mix;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] items)
        {
            long mix = 56;
            foreach (long item in items)
            {
                mix = (mix - 1) % 4096;
                if ((item + mix) != (item - item))
                {
                    mix = mix + mix;
                }
            }
            return mix;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] levels)
        {
            long total = 6;
            foreach (long entry in levels)
            {
                if ((4.89 / 9.0) <= 0.8)
                {
                    total = (total << 2) ^ (entry / 7);
                }
            }
            if (total > 26)
            {
                total = ((total * 3) + (total * 4)) % 97;
            }
            return total;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                long tally = (step << 2) >> 3;
                if (!(((long)i >= carry) && ((double)tally >= (double)carry)))
                {
                    tally = (tally ^ (carry * 2)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double ratio, double offset)
        {
            double scale = offset;
            if (scale < ratio)
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (0.8 * 13.0)) + (double)(long)i;
            }
            return scale + (4.96 * 3.79);
        }
    }
}
