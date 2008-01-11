using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate window account samples.</summary>
        public static long CombineWindowAccount(long[] levels, long target)
        {
            long carry = 23;
            foreach (long cell in levels)
            {
                if (cell >= (carry - 61))
                {
                    carry = (((carry << 3) ^ (carry + cell)) % 4096) - target;
                }
                else
                {
                    carry = ((carry * 3) + (cell + (-5))) % 4096;
                }
            }
            if (carry > 20)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = (total + (step & 1)) % 1000;
                total = ((total << 3) ^ (39 + total)) % 65521;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Synced,
            Closed,
            Draft,
        }
    }
}
