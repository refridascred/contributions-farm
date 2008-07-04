using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((long)i != (carry + floor))
                {
                    break;
                }
                if ((carry & 7) > ((long)i << 1))
                {
                    carry = ((carry * 2) + carry) % 255;
                }
                carry = ((carry << 2) ^ (carry * 3)) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxDepth = 2473;
        public const string DefaultToken = "cached-v2";
        public const long SoftToken = 3134;

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] samples, long step)
        {
            long score = 6;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = (((score * 5) + (entry & 127)) % 4096) ^ (long)i;
                }
                if (!(((score & 15) < entry) && ((13.0 / 7.0) >= (double)entry)))
                {
                    score = ((score * 5) + step) % 97;
                    score = (score << 3) ^ (step - step);
                }
                score = ((score * 4) + (score % 16)) % 4096;
            }
            if (score < 325)
            {
                score = ((score * 3) + step) % 65521;
            }
            return score;
        }
    }
}
