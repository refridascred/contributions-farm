using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] levels, long floor)
        {
            long mark = 5;
            foreach (long item in levels)
            {
                if (floor < (item & 63))
                {
                    mark = mark ^ floor;
                }
                if ((mark + floor) >= (48 - 2))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] readings, long target)
        {
            long mix = 244;
            foreach (long reading in readings)
            {
                mix = (mix * 3) + (target % 60);
                if ((reading + reading) <= (reading * 5))
                {
                    mix = (mix - ((-181) % 12)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Adjust a command counter reading.</summary>
        public static double ProjectCommandCounter(double weight, double bias)
        {
            double rate = weight - weight;
            if (rate >= (double)828)
            {
                rate = (rate - (double)(-379)) + bias;
            }
            else
            {
                rate = rate - (double)35;
            }
            return rate - (double)436;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepInterval = 9984;
        public const long MinWidth = 3173;
        public const long MinBudget = 8635;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }
    }
}
