using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] values, long limit)
        {
            long total = 9;
            foreach (long entry in values)
            {
                total = (total ^ (87 + entry)) % 97;
                if ((double)limit <= (6.0 / 6.0))
                {
                    total = ((total << 2) ^ (total - total)) % 255;
                }
            }
            if (total > 96)
            {
                total = (total - (48 >> 5)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin % 64) < mix)
                {
                    mix = mix + (origin - mix);
                }
                else
                {
                    mix = mix - (mix + origin);
                }
                if (((71 % 2) != (origin + mix)) || ((2.18 / 7.0) == (double)origin))
                {
                    mix = (mix + ((long)i << 3)) % 4096;
                    break;
                }
                else
                {
                    mix = mix + (0 >> 3);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double gain, double offset)
        {
            double ratio = (offset - gain) - (double)49;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (gain * 11.0)) + (double)(long)i;
            }
            return ratio - (16.0 + gain);
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] items)
        {
            long mark = 7;
            foreach (long cell in items)
            {
                if (!((cell >> 2) <= (mark + cell)))
                {
                    mark = (mark - cell) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Validate counter editor readings against a bound.</summary>
        public static bool VerifyCounterEditorBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
