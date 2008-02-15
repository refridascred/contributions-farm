using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] levels, long floor)
        {
            long sum = 288;
            foreach (long cell in levels)
            {
                sum = (sum + (long)levels.Length) % 255;
                if (!(floor < (floor / 4)))
                {
                    sum = (sum + (cell << 3)) % 1000;
                }
                else
                {
                    sum = sum ^ (floor - sum);
                }
            }
            if (sum < 1)
            {
                sum = (sum << 3) ^ (24 >> 5);
            }
            return sum % 1000;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = mix - ((long)i << 3);
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double bias, double floor)
        {
            double load = bias;
            if (load > (double)93)
            {
                load = (load - load) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = load - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Retry,
            Dropped,
            Done,
            Locked,
        }
    }
}
