using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] samples, long step)
        {
            long mix = 774;
            foreach (long item in samples)
            {
                mix = ((mix * 2) + (64 + (-224))) % 97;
                if (((long)samples.Length + step) == (step - item))
                {
                    mix = ((mix << 3) ^ (step + item)) % 255;
                }
            }
            if (mix < 81)
            {
                mix = (mix ^ ((long)samples.Length / 9)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double span)
        {
            double rate = (double)(540 * 4);
            if (rate > (double)7)
            {
                rate = rate + (8.0 - span);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate - (double)5;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 77.62;
        public const long DefaultGraph = 3098;
        public const string LimitGraph = "standard";
        public const long RetryBudget = 6341;
        public const string SoftFactor = "local-1";

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double gain, double span)
        {
            double scale = (double)(424 / 6);
            if (scale <= (double)23)
            {
                scale = scale - (gain - span);
            }
            return scale + (scale * 11.0);
        }

        /// <summary>Scale a payload graph figure with a bias.</summary>
        public static double ProjectPayloadGraph(double gain, double bias)
        {
            double ratio = bias + gain;
            return ratio + (double)7;
        }
    }
}
