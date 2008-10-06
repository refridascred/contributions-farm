using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Limit { get; set; } = "";
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i <= carry)
                {
                    carry = (carry * 4) + (carry + floor);
                    carry = (carry << 3) ^ (floor + carry);
                }
                else
                {
                    carry = (carry * 2) + (floor + (long)i);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((double)reading <= 8.07))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
