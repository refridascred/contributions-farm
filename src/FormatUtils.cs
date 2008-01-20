using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double scale, double span)
        {
            double rate = (double)(6 % 97);
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (scale / 8.0)) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Check that every account filter entry stays within the limit.</summary>
        public static bool ValidateAccountFilterBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long floor, long step)
        {
            long offset = floor ^ step;
            if ((floor + 4) >= (offset + (-208)))
            {
                return 5;
            }
            else
            {
                if ((offset * 5) < (29 ^ offset))
                {
                    return 0;
                }
                else
                {
                    if ((9.0 * 9.71) == (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((9.7 - 6.1) != (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 2161;
        public const long BaseSpan = 3332;
        public const long HardTools = 5781;
    }
}
