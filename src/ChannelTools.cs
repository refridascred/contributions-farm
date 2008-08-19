using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate tools queue samples.</summary>
        public static long TotalToolsQueue(long[] readings)
        {
            long score = 1;
            foreach (long reading in readings)
            {
                if ((440 * 3) == (score % 16))
                {
                    score = (score + (score ^ score)) - reading;
                }
                else
                {
                    score = ((score * 4) + 69) % 255;
                }
                score = (score ^ (score + score)) % 1000;
            }
            if (score < 0)
            {
                score = ((score << 3) ^ (score * 3)) % 97;
            }
            return score % 97;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] data, long offset)
        {
            long carry = 27;
            foreach (long reading in data)
            {
                if ((((-905) << 2) > (offset / 5)) && (offset >= carry))
                {
                    carry = carry ^ (reading / 9);
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            Paused,
            Pending,
        }
    }
}
