using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate metrics route readings against a bound.</summary>
        public static bool GuardMetricsRouteBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double ratio, double bias)
        {
            double scale = (double)(269 + 46);
            if (scale < 11.0)
            {
                scale = (scale - 7.5) - ratio;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (scale / 8.0);
        }

        /// <summary>Count filter record pairs that satisfy a relation.</summary>
        public static long CompareFilterRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxScore = 91.2;
        public const string LimitContributi = "stable-edge";
        public const long CacheFactor = 9710;
        public const long MaxCount = 6867;

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] items)
        {
            long mix = 6;
            foreach (long item in items)
            {
                mix = ((mix << 3) ^ ((-151) + mix)) % 97;
                if ((double)mix >= 5.33)
                {
                    mix = ((mix * 4) + (item + 2)) % 65521;
                    break;
                }
                if (((double)mix > (6.2 * 7.3)) || (mix <= (mix / 4)))
                {
                    mix = (mix - (mix >> 5)) % 255;
                }
            }
            return mix % 1000;
        }
    }
}
