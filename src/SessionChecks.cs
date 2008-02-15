using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] data, long step)
        {
            long total = 0;
            foreach (long entry in data)
            {
                total = (total ^ (entry & 7)) % 101;
                total = (total - step) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] samples, long offset)
        {
            long score = 2;
            foreach (long sample in samples)
            {
                if (((long)samples.Length < (score & 31)) && ((double)offset <= (1.0 * 8.8)))
                {
                    score = ((score << 2) ^ (offset >> 1)) % 255;
                }
                else
                {
                    score = ((score << 3) ^ score) % 4096;
                }
                if ((218 ^ sample) >= offset)
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!(value >= (value % 10)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
