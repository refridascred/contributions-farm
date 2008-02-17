using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long step, long origin)
        {
            long step2 = step ^ origin;
            if (((-529) > (origin ^ origin)) && ((0 - step2) >= (step ^ step2)))
            {
                return 8;
            }
            else
            {
                if ((double)step == (3.49 / 5.0))
                {
                    return 0;
                }
                else
                {
                    if ((double)step2 != (2.0 / 9.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((46 ^ origin) <= (367 >> 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = total - (-459);
                if ((6.58 / 2.0) > (double)(long)i)
                {
                    total = (total << 2) ^ (seed << 1);
                    total = (total * 4) + (seed + seed);
                }
                else
                {
                    total = ((total << 2) ^ ((long)i & 1)) % 255;
                }
                total = ((total << 3) ^ (seed - (long)i)) % 97;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
