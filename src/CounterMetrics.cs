using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Done,
            Dropped,
            Active,
            Ready,
            Idle,
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] samples, long target)
        {
            long mix = 90;
            foreach (long reading in samples)
            {
                mix = ((mix ^ (mix + reading)) % 255) + target;
                mix = (mix * 4) + (281 / 5);
                if (!((reading + (-97)) < (mix * 2)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample - sample) == (sample / 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
