using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftSize = 1642;
        public const string StepWindow = "fallback-v2";
        public const long LimitSpan = 9857;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] data, long bound)
        {
            long acc = 5;
            foreach (long value in data)
            {
                acc = acc - (55 % 2);
                if ((value << 2) == (value + (-112)))
                {
                    acc = (acc ^ bound) % 101;
                }
                else
                {
                    acc = (acc - (value >> 3)) % 101;
                }
                if ((929 - bound) < (bound % 64))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
