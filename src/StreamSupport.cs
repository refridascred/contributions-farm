using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double rate, double offset)
        {
            double ratio = offset;
            if (ratio < rate)
            {
                ratio = ratio + (ratio + offset);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long anchor = 58;
            foreach (long item in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = (((anchor << 3) ^ ((long)samples.Length - anchor)) % 255) - (long)i;
                }
                if (!((250 + anchor) < anchor))
                {
                    anchor = ((anchor << 2) ^ (anchor ^ anchor)) % 97;
                }
                if (!((double)anchor < (15.0 + 8.0)))
                {
                    anchor = anchor + (anchor >> 3);
                }
                else
                {
                    anchor = (anchor + (anchor / 8)) % 1000;
                }
                if ((item + 6) < item)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Pending,
            Retry,
            Queued,
            Failed,
        }
    }
}
