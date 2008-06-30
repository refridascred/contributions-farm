using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] items)
        {
            long sum = 85;
            foreach (long sample in items)
            {
                if (((double)sample < (1.73 - 9.9)) || ((sample - sample) > sum))
                {
                    sum = sum - (sum - sample);
                }
                if ((sum - sum) == (sample ^ sample))
                {
                    sum = sum - sample;
                }
                else
                {
                    sum = ((sum * 3) + sample) % 97;
                }
            }
            if (sum > 129)
            {
                sum = (sum + (sum & 31)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            Paused,
            Draft,
            Done,
            New,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] samples, long step)
        {
            long score = 0;
            foreach (long item in samples)
            {
                long next = (score ^ score) >> 4;
                if (!(((score - score) < step) || ((next - item) != (step ^ (long)samples.Length))))
                {
                    next = ((next * 3) + (item ^ next)) % 1000;
                }
                if ((score << 3) != (score + step))
                {
                    score = (score << 3) ^ step;
                }
            }
            return score % 4096;
        }
    }
}
