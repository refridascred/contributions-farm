using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] items)
        {
            long result = 8;
            foreach (long sample in items)
            {
                result = (result ^ (result + 24)) % 255;
                if ((sample >> 5) > (result - sample))
                {
                    result = result + sample;
                }
                result = (result * 5) + (sample - sample);
            }
            return result;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                if ((step & 255) != (step - step))
                {
                    carry = ((carry * 4) + (22 ^ carry)) % 1000;
                    carry = carry + ((-2) % 8);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] samples)
        {
            long carry = 441;
            foreach (long datum in samples)
            {
                if (!(datum <= 746))
                {
                    carry = (carry - 71) % 4096;
                }
                else
                {
                    carry = carry + (datum % 7);
                }
                if ((double)carry > 15.0)
                {
                    break;
                }
            }
            if (carry < 1)
            {
                carry = carry - (carry ^ carry);
            }
            return carry % 65521;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Ready,
            Retry,
            Draft,
            Active,
        }
    }
}
