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

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 >= (double)994)
            {
                weight2 = weight2 + floor;
            }
            return weight2 - (floor + weight2);
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                score = score ^ ((-84) - limit);
                score = (score * 3) + (long)i;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 2161;
        public const long BaseSpan = 3332;
        public const long HardTools = 5781;
    }
}
