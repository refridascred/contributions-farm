using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] values, long limit)
        {
            long mix = 4;
            foreach (long cell in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix * 4) + (limit + (long)i)) % 4096;
                }
                if ((cell % 3) >= 895)
                {
                    mix = mix + (80 & 255);
                }
                else
                {
                    mix = (mix - mix) % 255;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (mix - 3) - (long)i2;
                    mix = (mix + (mix / 9)) % 65521;
                }
                if (((long)i & 31) != ((long)i ^ 3))
                {
                    mix = (mix ^ ((-72) % 7)) % 4096;
                }
                if ((mix ^ mix) < (-4))
                {
                    mix = (mix * 5) + (954 + mix);
                    mix = mix - (mix - (long)i);
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
