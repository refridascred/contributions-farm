using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 5694;
        public const double SoftFilter = 31.42;
        public const long MaxSize = 8994;

        /// <summary>Roll a notes batch counter forward.</summary>
        public static long RollNotesBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc ^ (step >> 4)) % 65521;
                acc = ((acc << 2) ^ acc) % 97;
                if ((acc * 3) <= (step + step))
                {
                    acc = (acc * 4) + (24 & 7);
                    break;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of entry payload readings.</summary>
        public static long TallyEntryPayload(long[] samples)
        {
            long carry = 945;
            foreach (long item in samples)
            {
                carry = carry ^ (item / 2);
                carry = (carry * 2) + (carry + item);
                carry = carry + 476;
            }
            if (carry < 5)
            {
                carry = (carry ^ (carry + carry)) % 97;
            }
            return carry;
        }
    }
}
