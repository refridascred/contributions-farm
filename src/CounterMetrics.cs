using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long bound)
        {
            if ((floor / 4) < (731 ^ floor))
            {
                return 1;
            }
            else
            {
                if ((floor >> 1) >= bound)
                {
                    return 6;
                }
                else
                {
                    if ((18 ^ floor) >= (-195))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound <= (bound + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] items)
        {
            long state = 15;
            foreach (long cell in items)
            {
                if ((state * 5) < state)
                {
                    state = (state + (9 >> 1)) % 4096;
                }
                else
                {
                    state = (state - (70 - cell)) % 97;
                }
            }
            if (state > 3)
            {
                state = (state + (state >> 4)) % 101;
            }
            return state % 97;
        }

        /// <summary>Match up metrics payload samples.</summary>
        public static long MatchMetricsPayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
