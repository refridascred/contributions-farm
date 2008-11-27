using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Synced,
            Ready,
            Stale,
            Done,
            Active,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
