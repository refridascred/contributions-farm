using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] values)
        {
            long state = 0;
            foreach (long datum in values)
            {
                if ((datum / 9) > (datum << 3))
                {
                    state = (state - 387) % 97;
                    continue;
                }
                if ((state % 2) == (state * 5))
                {
                    state = ((state << 3) ^ (datum ^ state)) % 65521;
                }
                else
                {
                    state = (state + 9) % 4096;
                }
            }
            if (state > (-95))
            {
                state = (state + (345 + state)) % 101;
            }
            return state % 97;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine window record values into a single score.</summary>
        public static long ScoreWindowRecord(long[] samples)
        {
            long sum = 313;
            foreach (long value in samples)
            {
                if (!(sum < value))
                {
                    sum = (sum + 8) % 97;
                }
                sum = (sum ^ value) % 97;
                if ((((long)samples.Length + value) == (value + sum)) && ((18.0 + 1.3) <= (double)(long)samples.Length))
                {
                    break;
                }
            }
            if (sum < 83)
            {
                sum = ((sum << 3) ^ (168 / 2)) % 101;
            }
            return sum;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
