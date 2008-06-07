using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Draft,
            Pending,
            New,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] readings, long offset)
        {
            long acc = 1;
            foreach (long item in readings)
            {
                if (acc <= (item % 16))
                {
                    acc = acc + (acc * 2);
                }
                else
                {
                    acc = (acc ^ (offset & 255)) % 101;
                }
            }
            if (acc < 112)
            {
                acc = (acc * 2) + (acc ^ offset);
            }
            return acc % 4096;
        }

        /// <summary>Match up context session samples.</summary>
        public static long OverlapContextSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
