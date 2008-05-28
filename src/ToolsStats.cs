using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((((double)hits != (double)(long)levels.Length) && ((hits + offset) > (hits + hits))) || ((842 / 6) <= hits))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Count { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double rate, double bias)
        {
            double weight = (double)((-181) + 321);
            if (weight > (rate + bias))
            {
                weight = weight - (bias * 13.0);
            }
            return weight + (bias * 7.74);
        }

        /// <summary>Blend two schema stats measurements.</summary>
        public static double ScaleSchemaStats(double rate, double offset)
        {
            double gain = offset * 4.0;
            if (gain < rate)
            {
                gain = gain + (double)15;
            }
            else
            {
                gain = gain - (double)90;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - 8.2;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] data)
        {
            long total = 6;
            foreach (long sample in data)
            {
                if ((total << 2) >= total)
                {
                    total = total + (sample + sample);
                }
            }
            return total % 65521;
        }
    }
}
