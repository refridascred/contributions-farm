using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Synced,
            Done,
            Locked,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter filter values into a single score.</summary>
        public static long TotalCounterFilter(long[] values, long bound)
        {
            long state = 1;
            foreach (long datum in values)
            {
                if (bound >= (state / 6))
                {
                    state = (state + (datum + datum)) % 101;
                }
            }
            if (state < 9)
            {
                state = ((state * 5) + ((long)values.Length << 3)) % 4096;
            }
            return state;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long target, long origin)
        {
            long slot = target - origin;
            if (!((10.0 + 4.0) >= (double)slot))
            {
                return 1;
            }
            else
            {
                if ((slot / 8) < target)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double scale = (double)(1 >> 5);
            if (scale < (rate / 6.0))
            {
                scale = scale - (bias - bias);
            }
            else
            {
                scale = scale - (double)554;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (rate * 7.7)) - (double)(long)i;
            }
            return scale + (4.9 + rate);
        }
    }
}
