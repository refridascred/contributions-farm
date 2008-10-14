using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                mix = mix + (long)i;
                if (98 < mix)
                {
                    long gap = (long)i;
                    mix = (mix ^ gap) % 101;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix ^ ((long)i - origin)) % 4096) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Closed,
            Queued,
            Synced,
            Paused,
            Dropped,
        }

        /// <summary>Audit order buffer readings against a rule.</summary>
        public static long AuditOrderBufferGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample - count) >= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
