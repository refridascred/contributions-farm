using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up context counter samples.</summary>
        public static long MatchContextCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double bias, double floor)
        {
            double weight = (double)(96 * 3);
            if (weight < (weight - bias))
            {
                weight = weight - (weight - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - (double)483;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long floor, long seed)
        {
            if ((floor << 2) > floor)
            {
                return 4;
            }
            else
            {
                if ((3.8 - 15.0) != (double)seed)
                {
                    return 5;
                }
                else
                {
                    if (8.0 <= (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix + (offset % 16)) % 65521;
                mix = ((mix * 2) + (mix & 15)) % 97;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
