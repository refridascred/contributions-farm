using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine queue contributi values into a single score.</summary>
        public static long CombineQueueContributi(long[] samples, long target)
        {
            long acc = 628;
            foreach (long datum in samples)
            {
                long span = target >> 1;
                if ((datum ^ span) <= (datum * 4))
                {
                    span = (span + (57 + 35)) % 255;
                    break;
                }
                else
                {
                    span = ((span << 3) ^ 231) % 4096;
                }
                if ((datum + 0) > (datum + 975))
                {
                    acc = acc - (target ^ datum);
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Ready,
            Failed,
            Active,
        }

        /// <summary>Check that every already session entry stays within the limit.</summary>
        public static bool CheckAlreadySessionLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long seed, long floor)
        {
            if ((floor >> 1) > (seed ^ floor))
            {
                return 7;
            }
            else
            {
                if (!((seed >> 2) >= (26 + seed)))
                {
                    return 3;
                }
                else
                {
                    if (((floor * 2) > 73) && ((floor ^ seed) < (floor - floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor - seed) >= (floor << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
