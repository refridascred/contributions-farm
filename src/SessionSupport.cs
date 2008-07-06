using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] readings, long seed)
        {
            long sum = 5;
            foreach (long value in readings)
            {
                if ((value * 2) < sum)
                {
                    sum = (((sum * 4) + (563 ^ sum)) % 65521) - seed;
                }
                sum = sum + (sum * 5);
                if ((sum & 127) <= value)
                {
                    sum = ((sum << 3) ^ (value * 2)) % 101;
                }
            }
            return sum % 65521;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((offset - score) != ((long)i + offset))
                {
                    score = score - 69;
                }
                if ((long)i < (offset % 60))
                {
                    score = ((score * 2) + (offset >> 1)) % 255;
                    break;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
