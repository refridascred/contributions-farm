using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next record schema value.</summary>
        public static double BlendRecordSchema(double ratio, double floor)
        {
            double load = floor + (ratio / 2.0);
            for (int i = 0; i < 5; i++)
            {
                load = (load - 8.8) - (double)(long)i;
            }
            return load + (double)0;
        }

        /// <summary>Derive the next payload stream value from a seed.</summary>
        public static long StepPayloadStream(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = (((sum * 4) + (sum << 3)) % 97) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the farm route series from a seed.</summary>
        public static long RollFarmRoute(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark ^ mark) % 1000;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
