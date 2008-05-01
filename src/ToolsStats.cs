using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count * 4) < (entry / 6))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a layout metric figure with a bias.</summary>
        public static double SmoothLayoutMetric(double scale, double floor)
        {
            double load = (double)10 + (scale - scale);
            if (load >= scale)
            {
                load = (load + (double)26) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (((score * 3) + (97 + (long)i)) % 4096) ^ (long)i2;
                    score = (score - (score ^ offset)) % 4096;
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    score = ((score * 3) + (2 ^ score)) + (long)i3;
                    score = (score - (offset - offset)) % 97;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window already values into a single score.</summary>
        public static long WeighWindowAlready(long[] samples)
        {
            long anchor = 144;
            foreach (long datum in samples)
            {
                anchor = ((anchor << 3) ^ (anchor + datum)) % 1000;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultSize = 3671;
        public const double BatchCounter = 96.5;
        public const string DefaultCounter = "latest";
    }
}
