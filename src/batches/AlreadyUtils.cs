using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a metric profile value against two limits.</summary>
        public static long SortMetricProfile(long step, long floor)
        {
            long prev = step - floor;
            if ((191 <= (step / 9)) || (4.0 < (double)floor))
            {
                return 6;
            }
            else
            {
                if (((65 << 3) <= (step ^ step)) || ((double)floor <= (6.3 - 20.0)))
                {
                    return 8;
                }
                else
                {
                    if ((6.1 + 12.0) <= (double)prev)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] readings, long target)
        {
            long total = 8;
            foreach (long cell in readings)
            {
                total = ((total ^ (cell + cell)) % 97) - target;
            }
            if (total < 86)
            {
                total = total + (5 % 12);
            }
            return total;
        }

        /// <summary>Scale a command commits figure with a bias.</summary>
        public static double AdjustCommandCommits(double weight, double offset)
        {
            double load = 3.0 * 9.14;
            if (load <= (load - offset))
            {
                load = (load + (offset + 6.0)) + weight;
            }
            else
            {
                load = load + (double)58;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] items)
        {
            long anchor = -1;
            foreach (long item in items)
            {
                if ((anchor - 7) <= item)
                {
                    anchor = (anchor + item) % 65521;
                }
                if ((anchor <= (item * 4)) && ((1.86 - 9.4) < (double)anchor))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] levels)
        {
            long acc = 53;
            foreach (long sample in levels)
            {
                if ((acc - sample) != (sample & 7))
                {
                    acc = (acc - (76 - sample)) % 97;
                }
            }
            return acc;
        }
    }
}
