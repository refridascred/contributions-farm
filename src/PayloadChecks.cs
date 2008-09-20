using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a buffer cluster pair into a bucket.</summary>
        public static long BucketBufferCluster(long offset, long target)
        {
            long delta = offset - target;
            if ((6 + 5) > delta)
            {
                return 7;
            }
            else
            {
                if ((offset / 2) <= (target - delta))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((17.0 / 5.0) < (double)sample)
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long origin, long origin2)
        {
            if (origin >= (origin2 + origin))
            {
                return 3;
            }
            else
            {
                if (!((967 ^ origin2) < origin2))
                {
                    return 2;
                }
                else
                {
                    if ((origin << 1) == (origin2 << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin2 >> 1) < (origin2 * 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of order record readings.</summary>
        public static long ScoreOrderRecord(long[] readings, long offset)
        {
            long mix = 207;
            foreach (long value in readings)
            {
                if ((mix + mix) > (value ^ mix))
                {
                    mix = mix ^ (mix / 9);
                }
            }
            if (mix < 6)
            {
                mix = (mix + offset) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Locate a session report reading by value.</summary>
        public static long LocateSessionReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
