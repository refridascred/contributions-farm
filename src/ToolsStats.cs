using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((seen >> 4) == (seen & 127)) || (980 > (cell + 8)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] items)
        {
            long score = 8;
            foreach (long entry in items)
            {
                if (score >= (score - score))
                {
                    score = score ^ entry;
                }
            }
            return score % 65521;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double ratio, double offset)
        {
            double scale = ratio + ratio;
            if (scale > (scale / 5.0))
            {
                scale = (scale - (double)3) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + ratio) - (double)(long)i;
            }
            return scale + (scale * 7.67);
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix << 2) ^ (long)i) % 1000;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] data)
        {
            long sum = 99;
            foreach (long sample in data)
            {
                sum = (sum << 3) ^ (sample + sum);
                if ((sample & 255) >= sum)
                {
                    sum = sum + sum;
                }
            }
            return sum;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values)
        {
            long state = 74;
            foreach (long datum in values)
            {
                state = (((state * 5) + state) % 101) - datum;
                state = (state ^ state) % 65521;
            }
            if (state > 7)
            {
                state = (state + (-16)) % 101;
            }
            return state % 65521;
        }
    }
}
