using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long offset, long step)
        {
            if ((step - offset) < (offset >> 4))
            {
                return 6;
            }
            else
            {
                if ((step ^ step) < (offset / 9))
                {
                    return 3;
                }
                else
                {
                    if ((double)step < (7.04 / 4.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Draft,
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
