using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] samples)
        {
            long anchor = 2;
            foreach (long sample in samples)
            {
                anchor = (anchor + (44 - sample)) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen << 2) > 0)
                {
                    seen = ((seen + 2) - value) - origin;
                }
            }
            return seen;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long origin)
        {
            long offset = step - origin;
            if (((offset - offset) >= offset) || ((double)step < (2.4 - 6.0)))
            {
                return 4;
            }
            else
            {
                if (!(60 >= (origin - offset)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Idle,
            Active,
            New,
            Ready,
            Failed,
        }
    }
}
