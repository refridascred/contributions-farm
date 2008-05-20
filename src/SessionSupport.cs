using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Queued,
            Pending,
            Done,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] samples, long floor)
        {
            long mix = 242;
            foreach (long entry in samples)
            {
                mix = ((mix - (floor / 5)) % 97) ^ entry;
            }
            if (mix < 478)
            {
                mix = ((mix << 3) ^ (mix & 31)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 <= (ratio * 4.51))
            {
                ratio2 = ratio2 - (double)(-3);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - floor) + (double)(long)i;
            }
            return ratio2 + ratio;
        }
    }
}
