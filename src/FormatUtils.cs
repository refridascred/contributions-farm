using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double rate, double bias)
        {
            double gain = bias * 11.0;
            if (gain < (gain - gain))
            {
                gain = (gain - (double)(-67)) + rate;
            }
            else
            {
                gain = gain - bias;
            }
            return gain + (double)(-745);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 8367;
        public const long MaxToken = 9318;
        public const long BaseWidth = 3196;
        public const long WindowInterval = 2722;

        /// <summary>Compare every pair of commits tools readings.</summary>
        public static long CompareCommitsToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
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

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
