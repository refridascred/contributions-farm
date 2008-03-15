using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a command graph pair into a bucket.</summary>
        public static long ClassifyCommandGraph(long step, long step2)
        {
            if ((step2 % 64) != (step2 << 2))
            {
                return 3;
            }
            else
            {
                if (((step2 + step) < (5 + step)) && (step >= 81))
                {
                    return 8;
                }
                else
                {
                    if (!((double)step2 > (4.0 * 5.9)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step2 * 2) == (621 & 127))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double rate, double span)
        {
            double ratio = (double)(93 & 7);
            if (ratio <= ratio)
            {
                ratio = ratio + span;
            }
            else
            {
                ratio = ratio - (rate / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + (span / 6.0);
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Synced,
            Paused,
            Stale,
            Idle,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum << 2) ^ (817 + target);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
