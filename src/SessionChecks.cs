using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Synced,
            New,
            Failed,
        }

        /// <summary>Find the first stats contributi entry that matches the target.</summary>
        public static long SeekStatsContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long seed, long limit)
        {
            if ((54 - limit) != (limit >> 5))
            {
                return 5;
            }
            else
            {
                if ((seed & 63) != (3 ^ limit))
                {
                    return 3;
                }
                else
                {
                    if ((limit <= 7) || (seed > (seed - 279)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(seed >= (seed - seed)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((step * 2) <= (step - item)) || !((matches ^ 68) >= 121))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
