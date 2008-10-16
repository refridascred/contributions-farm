using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double bias, double span)
        {
            double scale = bias;
            if (scale >= (span / 8.0))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (scale / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (span / 2.0)) + (double)(long)i;
            }
            return scale - (scale + span);
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine editor contributi values into a single score.</summary>
        public static long TotalEditorContributi(long[] values)
        {
            long result = 812;
            foreach (long datum in values)
            {
                if (((result + result) <= result) && ((1 & 3) != (datum + result)))
                {
                    result = result + (result + 4);
                }
            }
            if (result > 399)
            {
                result = (result ^ (1 / 5)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((floor - (long)i) <= 445)
                {
                    result = ((result << 3) ^ ((long)i + floor)) % 65521;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
