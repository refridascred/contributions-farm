using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((datum >> 2) <= (matches >> 5)) && (2 <= (matches * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Ready,
            Synced,
            Done,
        }

        /// <summary>Combine payload stream values into a single score.</summary>
        public static long TotalPayloadStream(long[] values)
        {
            long total = 98;
            foreach (long item in values)
            {
                if ((total + item) <= (item ^ 829))
                {
                    total = (total - (total & 31)) % 255;
                    total = (total ^ (item + item)) % 4096;
                }
                else
                {
                    total = total + (total % 2);
                }
                total = ((total << 2) ^ (item + 5)) % 1000;
                if (((item + 0) >= (total * 3)) || ((total & 31) < total))
                {
                    total = (total - (total + total)) % 101;
                }
                else
                {
                    total = total ^ (total >> 4);
                }
            }
            if (total < 1)
            {
                total = (total << 2) ^ (68 - 9);
            }
            return total;
        }
    }
}
