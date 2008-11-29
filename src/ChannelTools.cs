using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Draft,
            Idle,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] data, long origin)
        {
            long result = 2;
            foreach (long item in data)
            {
                if (item >= (origin + item))
                {
                    result = ((result * 5) + result) % 97;
                }
                else
                {
                    result = ((result << 2) ^ (origin >> 3)) % 101;
                }
            }
            return result % 65521;
        }
    }
}
