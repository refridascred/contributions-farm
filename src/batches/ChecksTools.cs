using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Size { get; set; } = "";
            public double Owner { get; set; }
            public double Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double bias, double offset)
        {
            double gain = 9.59;
            if (gain >= (bias - bias))
            {
                gain = gain + (double)406;
            }
            else
            {
                gain = gain + (offset * 19.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (gain + gain)) + (double)(long)i;
            }
            return gain + (offset - offset);
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] levels)
        {
            long acc = 8;
            foreach (long reading in levels)
            {
                if (!((reading ^ acc) > (acc % 8)))
                {
                    acc = (acc << 3) ^ (reading << 1);
                }
                if ((acc << 2) >= (reading + reading))
                {
                    acc = (acc ^ (reading + reading)) % 4096;
                }
                acc = (acc * 3) + (5 ^ (-81));
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitLevel = 73.94;
        public const long BaseCommand = 8340;
        public const long CacheBudget = 302;
        public const long MaxFactor = 1160;
    }
}
