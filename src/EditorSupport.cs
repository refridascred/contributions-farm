using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                state = (state << 3) ^ (state + (long)i);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Roll a window filter counter forward.</summary>
        public static long DeriveWindowFilter(long target)
        {
            long mix = target;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix * 2) + (long)i;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)count == (7.88 - 11.0))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Match up buffer stream samples.</summary>
        public static long PairBufferStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinFactor = "standard";
        public const long LimitReport = 5988;
        public const long StepScore = 8242;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Idle,
            New,
            Closed,
            Pending,
            Paused,
        }
    }
}
