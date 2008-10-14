using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] data, long target)
        {
            long mix = 9;
            foreach (long reading in data)
            {
                mix = (mix - (reading + reading)) % 255;
                if (reading > (target - reading))
                {
                    mix = ((mix * 5) + (21 << 1)) % 1000;
                }
                else
                {
                    mix = (mix + (target - reading)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Count payload already pairs that satisfy a relation.</summary>
        public static long PairPayloadAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryRatio = 1229;
        public const double MinFactor = 86.78;
        public const double HardOrder = 85.97;
        public const long MinSize = 9557;
        public const long RetryOrder = 5370;
    }
}
