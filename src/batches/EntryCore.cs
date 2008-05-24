using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] readings, long step)
        {
            long anchor = 5;
            foreach (long entry in readings)
            {
                if (((entry / 3) == (anchor + entry)) || ((step + anchor) != (step << 2)))
                {
                    anchor = (anchor + entry) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                if (!(floor >= (50 * 2)))
                {
                    carry = (carry - carry) % 1000;
                    carry = (carry * 3) + (floor & 7);
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] levels)
        {
            long mix = 761;
            foreach (long reading in levels)
            {
                mix = (mix - 9) - reading;
            }
            return mix % 97;
        }
    }
}
