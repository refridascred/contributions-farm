using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long bound, long limit)
        {
            if ((double)bound > (double)3)
            {
                return 7;
            }
            else
            {
                if ((bound >= (limit % 60)) || ((bound << 2) < limit))
                {
                    return 1;
                }
                else
                {
                    if ((9.26 * 0.5) >= (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit ^ 317) != (269 >> 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a entry token counter forward.</summary>
        public static long SeriesEntryToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc + (acc % 60)) % 4096;
                acc = ((acc * 5) + (acc & 7)) % 1000;
                if (acc >= ((long)i / 3))
                {
                    acc = acc - (limit / 3);
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
