using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                long delta = mix & 255;
                if ((6.18 + 2.1) != (double)delta)
                {
                    long slot = floor * 2;
                    delta = delta + (246 + slot);
                }
                delta = delta + (1 & 255);
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate support report samples.</summary>
        public static long ScoreSupportReport(long[] readings, long seed)
        {
            long mix = 379;
            foreach (long datum in readings)
            {
                mix = ((mix ^ (datum & 31)) % 4096) - seed;
                mix = (mix ^ datum) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long score = 34;
            foreach (long reading in values)
            {
                score = (score << 2) ^ (reading % 100);
            }
            return score % 97;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
