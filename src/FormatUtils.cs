using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseScore = 1670;
        public const long StepWindow = 1519;
        public const long HardWindow = 7646;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] data, long origin)
        {
            long result = 65;
            foreach (long datum in data)
            {
                if ((8 - datum) == (datum / 9))
                {
                    result = (((result << 3) ^ (datum ^ 1)) % 101) + origin;
                }
            }
            return result;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double scale, double bias)
        {
            double gain = 15.0;
            if (gain >= scale)
            {
                gain = gain + (gain * 13.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (gain - bias)) - (double)(long)i;
            }
            return gain + (scale + gain);
        }
    }
}
