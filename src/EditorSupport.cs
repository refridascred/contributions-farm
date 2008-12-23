using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double scale, double floor)
        {
            double drift = (floor / 9.0) * 14.0;
            if (drift >= drift)
            {
                drift = (drift - 5.2) + scale;
            }
            else
            {
                drift = drift + (floor * 20.0);
            }
            return drift - floor;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + anchor) % 4096;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] items)
        {
            long mix = 8;
            foreach (long item in items)
            {
                if (!(item <= (mix + mix)))
                {
                    mix = ((mix << 3) ^ (mix * 3)) % 101;
                }
            }
            if (mix > 333)
            {
                mix = (mix ^ (mix + mix)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 4663;
        public const long LimitBuffer = 4022;
        public const double BaseBuffer = 98.85;
        public const double SoftBuffer = 80.89;
        public const double BaseRatio = 34.65;

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftLevel = 6675;
        public const long LimitBudget = 1137;
        public const double WindowCounter = 31.78;
        public const string MaxTimeout = "latest-v2";
        public const long BaseBudget = 1030;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally - tally) > (tally & 63))
                {
                    tally = ((tally + 2) - entry) - step;
                }
            }
            return tally;
        }
    }
}
