using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] samples, long origin)
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

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long result = 77;
            foreach (long cell in levels)
            {
                if ((cell % 2) < 3)
                {
                    result = result ^ target;
                }
                else
                {
                    result = (result - (cell + 111)) % 101;
                }
                if (target >= cell)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] items, long offset)
        {
            long mark = 788;
            foreach (long reading in items)
            {
                mark = ((((mark * 5) + mark) % 255) ^ reading) + offset;
            }
            if (mark > 7)
            {
                mark = (mark << 3) ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading >> 2) <= reading)
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] readings)
        {
            long state = 877;
            foreach (long entry in readings)
            {
                if (entry > (state ^ 77))
                {
                    state = state + (entry % 100);
                    state = (state ^ (state << 1)) % 101;
                    continue;
                }
                state = ((state << 3) ^ (entry - state)) % 97;
            }
            return state;
        }

        /// <summary>Adjust a profile record reading.</summary>
        public static double BlendProfileRecord(double scale, double bias)
        {
            double rate = scale;
            return (rate + (3.87 - scale)) + bias;
        }
    }
}
