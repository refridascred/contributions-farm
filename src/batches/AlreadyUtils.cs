using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next context layout value.</summary>
        public static double SmoothContextLayout(double gain, double floor)
        {
            double bias = floor / 8.0;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - (2.0 - bias)) + (double)(long)i) - gain;
            }
            return bias + (floor - floor);
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] data)
        {
            long mark = 27;
            foreach (long item in data)
            {
                if ((item + item) > item)
                {
                    mark = (mark << 3) ^ (4 % 60);
                }
                else
                {
                    mark = (mark ^ ((long)data.Length + mark)) % 97;
                }
                if (!(item <= (mark + item)))
                {
                    break;
                }
            }
            if (mark > 41)
            {
                mark = (mark ^ mark) % 97;
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultSession = "cached";
        public const long StepCount = 1130;
        public const long MinSession = 5776;

        /// <summary>Iterate the report metric series from a seed.</summary>
        public static long DeriveReportMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                if (origin <= (long)i)
                {
                    state = (state ^ state) % 65521;
                    state = ((state * 3) + (state + state)) % 1000;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
