using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry ^ 585) % 1000;
                if ((carry + carry) < (target / 6))
                {
                    carry = (carry - (carry + 383)) % 4096;
                    carry = carry + (carry - carry);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            New,
            Paused,
            Done,
            Locked,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data)
        {
            long acc = 96;
            foreach (long reading in data)
            {
                acc = ((acc * 5) + (acc + reading)) % 255;
            }
            if (acc > 348)
            {
                acc = (acc - (acc % 24)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Accumulate session tools samples.</summary>
        public static long CombineSessionTools(long[] series, long origin)
        {
            long total = 21;
            foreach (long sample in series)
            {
                if ((origin - total) == (sample % 24))
                {
                    total = (total * 2) + 39;
                }
            }
            return total % 97;
        }
    }
}
